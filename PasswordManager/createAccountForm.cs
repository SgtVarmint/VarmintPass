using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PasswordManager {
    public partial class createAccountForm : Form {

        string db_conn = @"server=<Server IP>;User ID=<DB User>;Password=<Admin Password>;Initial Catalog=<Database Table>";

        private SqlConnection con;

        public createAccountForm() {
            con = new SqlConnection(db_conn);
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void emptyField(Label label) {
            statusLabel.Text = $"All fields below need to be filled";
            statusLabel.ForeColor = Color.Red;

            label.Text = "*";
            label.ForeColor = Color.Red;
        }

        /**
         * TODO: 
         *  At some point, I have to do a check to make sure that the two password fields match, and if they don't, display an error.
         *  I should also implement some regex to ensure the user inputs a valid email as well as a valid password
         **/
        private void submitAccountButton_Click(object sender, EventArgs e) {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            int emptyFields = 1; //used to check if there are any empty fields; 1=true, 0=false
            string username = usernameBox.Text;
            string email = emailBox.Text;
            string password = passwordBox.Text == "" ? "" : BCrypt.Net.BCrypt.HashPassword(passwordBox.Text, salt);
            string passwordConfirm = confirmPassBox.Text == "" ? "" : BCrypt.Net.BCrypt.HashPassword(confirmPassBox.Text, salt);

            if (username == "") emptyField(usernameErrorLabel);
            if (email == "") emptyField(emailErrorLabel);
            if (password == "") emptyField(passwordErrorLabel);
            if (passwordConfirm == "") emptyField(confirmPassErrorLabel);
            else emptyFields = 0;

            //will enter here if all fields are filled in
            if (emptyFields == 0)
                try {
                    con.Open();
                    var userExistsCheck = $"select userID from users where username = @username or email = @email";
                    SqlCommand checkCommand = new SqlCommand(userExistsCheck, con);
                    checkCommand.Parameters.AddWithValue("@username", username);
                    checkCommand.Parameters.AddWithValue("@email", email);
                    SqlDataReader checkReturn = checkCommand.ExecuteReader();

                    if (checkReturn.HasRows) {
                        statusLabel.Text = $"Username or email already exists";
                        statusLabel.ForeColor = Color.Red;
                        checkReturn.Close();
                    }
                    else {
                        checkReturn.Close();
                        statusLabel.Text = "";
                        var createUserAccountStmt = $"insert into users (username, password, email) values (@username, @password, @email)";

                        SqlCommand insertUser = new SqlCommand(createUserAccountStmt, con);
                        insertUser.Parameters.AddWithValue("@username", username);
                        insertUser.Parameters.AddWithValue("@password", password);
                        insertUser.Parameters.AddWithValue("@email", email);

                        insertUser.ExecuteNonQuery();

                        statusLabel.Text = $"Account Created Successfully";
                        statusLabel.ForeColor = Color.Black;
                    }
                }
                catch (SqlException ex) {
                    Console.WriteLine(ex);
                }
                finally {
                    con.Close();
                }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e) {
            passwordBox.PasswordChar = '*';
        }

        private void confirmPassBox_TextChanged(object sender, EventArgs e) {
            confirmPassBox.PasswordChar = '*';
        }
    }
}
