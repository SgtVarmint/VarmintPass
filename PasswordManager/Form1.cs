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
    public partial class MainPane : Form {

        string db_conn = @"server=<Server IP>;User ID=<DB User>;Password=<Admin Password>;Initial Catalog=<Database Table>";
        private SqlConnection con;

        public MainPane() {
            con = new SqlConnection(db_conn);
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dashboardPanel.Hide();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e) {
            passwordBox.PasswordChar = '*';
        }

        private void userAuth() {
            /*
            join example because i always forget sql server syntax
            var stmt = $"SELECT u.userID, p.service, p.username, p.password from users AS u join passwords AS p ON (p.userID = u.userID)";
            */
            try {
                con.Open();
                string username = usernameBox.Text, password = passwordBox.Text;
                var stmt = $"select username,password from users where username like @username";

                SqlCommand auth = new SqlCommand(stmt, con);
                auth.Parameters.AddWithValue("@username", username);
                SqlDataReader userAuth = auth.ExecuteReader();

                if (userAuth.HasRows) {
                    userAuth.Read();
                    if (BCrypt.Net.BCrypt.Verify(password, userAuth.GetString(1)) == true) {
                        userAuth.Close();
                        //go to main page of password manager
                        loginPanel.Hide();
                        enableDashboard();
                    }
                    else {
                        invalidLoginLabel.Text = $"Invalid username or password";
                    }
                }
                else {
                    invalidLoginLabel.Text = $"Invalid username or password";
                }
            }
            catch (SqlException ex) {
                Console.WriteLine(ex);
            }
            finally {
                con.Close();
            }
        }

        private void loginButton_Click(object sender, EventArgs e) {
            userAuth();
        }

        private void usernameBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter)
                userAuth();
        }

        private void passwordBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter)
                userAuth();
        }

        /* ------- Account Creation Controls ------- */

        private void createAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new createAccountForm().Show();
        }

        /* ------- Dashboard Controls -------*/

        private bool serviceButtonClicked = false, emailButtonClicked = false, usernameButtonClicked = false, passwordButtonClicked = false;

        void enableDashboard() {
            dashboardPanel.Show();
            showData();
        }

        private void showData() {
            FlowLayoutPanel[] flows = new FlowLayoutPanel[50];
            int brh = 50;

            try {
                string username = usernameBox.Text;

                string stmt = $"SELECT p.service, p.email, p.username, p.password from passwords AS p join users AS u ON (p.userID = u.userID) ";

                if (serviceButtonClicked) stmt += "sort by service ASC";
                if (emailButtonClicked) stmt += "sort by email ASC";
                if (usernameButtonClicked) stmt += "sort by username ASC";
                if (passwordButtonClicked) stmt += "sort by password ASC";

                stmt += $"where p.userID = (select userID from users where u.username = @username)";

                SqlCommand retrieveData = new SqlCommand(stmt, con);
                retrieveData.Parameters.AddWithValue("@username", username);
                SqlDataReader loginInfo = retrieveData.ExecuteReader();

                for (int i = 0; i<10; i++) {
                    loginInfo.Read();
                    flows[i] = new FlowLayoutPanel();
                    flows[i].Name = "userInfoRow" + i;
                    flows[i].Location = new Point(0, brh);
                    flows[i].Size = new Size(800, 23);

                    Label service = new Label();
                    service.Name = "Service" + i;
                    service.Location = new Point(0, 23 + brh);
                    service.Size = new Size(116, 23 + brh);
                    service.Text = "test";
                    service.BorderStyle = BorderStyle.Fixed3D;
                    flows[i].Controls.Add(service);

                    dashboardPanel.Controls.Add(flows[i]);
                    brh += 23;
                }
            }
            catch (SqlException ex) {
                Console.WriteLine("Error connecting to database. Check connection and try again.");
            }
            finally {
                con.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            new NewPasswordEntry().Show();
        }

        private void serviceSortButton_Click(object sender, EventArgs e) {
            serviceButtonClicked = true;
        }

        private void emailSortButton_Click(object sender, EventArgs e) {
            emailButtonClicked = true;
        }

        private void usernameSortButton_Click(object sender, EventArgs e) {
            usernameButtonClicked = true;
        }

        private void passwordSortButton_Click(object sender, EventArgs e) {
            passwordButtonClicked = true;
        }
    }
}
