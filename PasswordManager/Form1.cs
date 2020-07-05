using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace PasswordManager {
    public partial class MainPane : Form {

        string db_ip, db_user, db_pass, db_database, db_conn;

        private SqlConnection con;
        private dbConfig dbConf;
        string username;
        private string confPath = $".\\conf.dat";
        private string dbConfPath = $".\\db.conf";
        byte[] K, IV;

        public MainPane() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dashboardPanel.Hide();
        }

        private void databaseConfigurationToolStripMenuItem_Click(object sender, EventArgs e) {
            dbConf = new dbConfig();
            dbConf.Show();
        }

        private void setDBCreds() {
            if (File.Exists(dbConfPath)) {
                using(StreamReader readIn = new StreamReader(dbConfPath)) {
                    db_ip = readIn.ReadLine();
                    db_user = readIn.ReadLine();
                    db_pass = readIn.ReadLine();
                    db_database = readIn.ReadLine();

                    readIn.Close();
                }
            }

            db_conn = $"server={db_ip};User ID={db_user};Password={db_pass};Initial Catalog={db_database}";
        }

        private void init() {
            if (!File.Exists(confPath)) {
                using (FileStream stream = File.Create(confPath)) {
                    using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider()) {
                        aes.BlockSize = 128;
                        aes.Padding = PaddingMode.PKCS7;
                        K = aes.Key;
                        IV = aes.IV;
                        stream.Write(K, 0, K.Length);
                    }
                }
            }

            using (FileStream stream = File.OpenRead(confPath))
                K = File.ReadAllBytes(confPath);
            try {
                //con.Open();

                var getIVStmt = $"SELECT IV from passwords where userID = (SELECT userID from users where username = @username)";
                SqlCommand getIVCmd = new SqlCommand(getIVStmt, con);
                getIVCmd.Parameters.AddWithValue("@username", getUsername());
                SqlDataReader getIV = getIVCmd.ExecuteReader();

                if (getIV.HasRows) {
                    getIV.Read();
                    IV = (byte[])getIV[0];
                }
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            finally { con.Close(); }
        }

        private string getUsername() { return this.username; }
        private void setUsername(string username) { this.username = username; }

        private void passwordBox_TextChanged(object sender, EventArgs e) {
            passwordBox.PasswordChar = '*';
        }

        private void userAuth() {
            /*
            join example because i always forget sql server syntax
            var stmt = $"SELECT u.userID, p.service, p.username, p.password from users AS u join passwords AS p ON (p.userID = u.userID)";
            */
            try {
                setDBCreds();
                con = new SqlConnection(db_conn);

                con.Open();
                string username = usernameBox.Text, password = passwordBox.Text;
                var stmt = $"select username,password from users where username = @username";

                SqlCommand auth = new SqlCommand(stmt, con);
                auth.Parameters.AddWithValue("@username", username);
                SqlDataReader userAuth = auth.ExecuteReader();

                if (userAuth.HasRows) {
                    userAuth.Read();
                    if (BCrypt.Net.BCrypt.Verify(password, userAuth.GetString(1)) == true) {
                        userAuth.Close();
                        setUsername(username);
                        init();
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
            new createAccountForm(db_conn).Show();
        }

        /* ------- Dashboard Controls -------*/

        private bool serviceButtonClicked = false, emailButtonClicked = false, usernameButtonClicked = false, passwordButtonClicked = false;

        void enableDashboard() {
            dashboardPanel.Show();
            showData();
        }

        private void showData() {
            try {
                con.Open();

                string username = getUsername();

                string stmt = $"SELECT p.service, p.email, p.username, p.password, p.IV from passwords AS p join users AS u ON (p.userID = u.userID) ";

                if (serviceButtonClicked) stmt += "sort by service ASC";
                if (emailButtonClicked) stmt += "sort by email ASC";
                if (usernameButtonClicked) stmt += "sort by username ASC";
                if (passwordButtonClicked) stmt += "sort by password ASC";

                stmt += $"where p.userID = (select userID from users where username = @username)";

                SqlCommand retrieveData = new SqlCommand(stmt, con);
                retrieveData.Parameters.AddWithValue("@username", username);
                SqlDataReader loginInfo = retrieveData.ExecuteReader();

                int brh = 25;

                for (int i = 0; loginInfo.Read(); i++) {
                    TableLayoutPanel row = new TableLayoutPanel();
                    row.Name = "TableLayout"+i;
                    row.Location = new Point(2, 23 + brh);
                    row.Size = new Size(1382, 23);
                    row.ColumnCount = 4;

                    row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 305));
                    row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 345));
                    row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 328));
                    row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 418));

                    Label serviceLabel = new Label();
                    serviceLabel.Location = new Point(0, 23 + brh);
                    serviceLabel.Size = new Size(305, 23);
                    serviceLabel.Text = loginInfo.GetString(0);
                    serviceLabel.Margin = new Padding(0, 0, 0, 0);
                    row.Controls.Add(serviceLabel, 0, 0);

                    Label emailLabel = new Label();
                    emailLabel.Location = new Point(304, 23 + brh);
                    emailLabel.Size = new Size(345, 23);
                    emailLabel.Text = loginInfo.GetString(1);
                    emailLabel.Margin = new Padding(0, 0, 0, 0);
                    row.Controls.Add(emailLabel, 1, 0);

                    Label usernameLabel = new Label();
                    usernameLabel.Location = new Point(648, 23 + brh);
                    usernameLabel.Size = new Size(328, 23);
                    usernameLabel.Text = loginInfo.GetString(2);
                    usernameLabel.Margin = new Padding(0, 0, 0, 0);
                    row.Controls.Add(usernameLabel, 2, 0);

                    Label passwordLabel = new Label();
                    passwordLabel.Location = new Point(975, 23 + brh);
                    passwordLabel.Size = new Size(418, 23);
                    passwordLabel.Text = decrypt((byte[])loginInfo[3], (byte[])loginInfo[4]);
                    passwordLabel.Margin = new Padding(0, 0, 0, 0);
                    row.Controls.Add(passwordLabel, 3, 0);

                    dashboardPanel.Controls.Add(row);
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

        private string decrypt(byte[] cipher, byte[] serviceIV) {
            byte[] plain = null;

            using (AesCryptoServiceProvider aesCSP = new AesCryptoServiceProvider()) {
                aesCSP.BlockSize = 128;
                aesCSP.Padding = PaddingMode.PKCS7;
                aesCSP.Key = K;
                aesCSP.IV = serviceIV;

                ICryptoTransform decryptor = aesCSP.CreateDecryptor(aesCSP.Key, aesCSP.IV);

                using (MemoryStream msDec = new MemoryStream())
                using (CryptoStream csDec = new CryptoStream(msDec, decryptor, CryptoStreamMode.Write))
                    plain = decryptor.TransformFinalBlock(cipher, 0, cipher.Length);
            }
            return Encoding.Unicode.GetString(plain);
        }

        private void addEntryButton_Click(object sender, EventArgs e) {
            new NewPasswordEntry(usernameBox.Text, db_conn).Show();
        }

        private void refreshDashboard_Click(object sender, EventArgs e) {
            showData();
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
