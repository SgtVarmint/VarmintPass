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
using System.Security.Cryptography;
using System.IO;

namespace PasswordManager {
    public partial class NewPasswordEntry : Form {

        private SqlConnection con;
        string username;
        private string confPath = $".\\conf.dat";
        byte[] K, IV;

        private string getUsername() { return this.username; }
        private void setUsername(string username) { this.username = username; }

        public NewPasswordEntry(string username, string db_conn) {
            setUsername(username);
            con = new SqlConnection(db_conn);
            init();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void init() {
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider()) {
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;
                IV = aes.IV;
            }

            using (FileStream stream = File.OpenRead(confPath))
                K = File.ReadAllBytes(confPath);
        }

        /*
         * The next steps I have to take for this are I have to implement checking for if there is already a service in the list, and I also have to implement enryption for the passwords.
         * Encryption is probably going to be some kind of AES or RSA.
         */
        private void submitButton_Click(object sender, EventArgs e) {
            try {
                con.Open();

                string stmt = "SELECT service from passwords WHERE service = @service AND userID = (select userID from users where username = @username)";

                SqlCommand serviceCheck = new SqlCommand(stmt, con);
                serviceCheck.Parameters.AddWithValue("@service", serviceBox.Text);
                serviceCheck.Parameters.AddWithValue("@username", getUsername());
                SqlDataReader serviceReader = serviceCheck.ExecuteReader();
                serviceCheck.Parameters.Clear();

                if (serviceReader.HasRows) {
                    statusLabel.Text = $"Already an entry for {serviceReader.GetString(0)}, remove or edit current entry.";
                }
                else {
                    serviceReader.Close();

                    string user = usernameBox.Text, service = serviceBox.Text, email = emailBox.Text, password = passwordBox.Text;

                    string newDetailsInsert = "INSERT INTO passwords values (@service, @email, @user, @password, @IV, (SELECT userID from users where username = @username))";

                    SqlCommand insertDetails = new SqlCommand(newDetailsInsert, con);
                    insertDetails.Parameters.AddWithValue("@service", service);
                    insertDetails.Parameters.AddWithValue("@email", email);
                    insertDetails.Parameters.AddWithValue("@user", user);
                    insertDetails.Parameters.AddWithValue("@password", encryptString(password));
                    insertDetails.Parameters.AddWithValue("@IV", IV);
                    insertDetails.Parameters.AddWithValue("@username", getUsername());

                    insertDetails.ExecuteNonQuery();

                    statusLabel.ForeColor = Color.Black;
                    statusLabel.Text = "Details successfully added.";

                }
            }
            catch (SqlException ex) {
                statusLabel.Text = "Login Info not added to database. Try again.";
                statusLabel.ForeColor = Color.Red;
                Console.WriteLine("Error connecting to the database. Check connection and try again.");
                Console.WriteLine(ex);
            }
            finally {
                con.Close();
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e) {
            passwordBox.PasswordChar = '*';
        }

        /* -------- Encryption --------*/
        private byte[] encryptString(string plainText) {
            byte[] encrypted = Encoding.Unicode.GetBytes(plainText);
            byte[] cipher = null;

            using (AesCryptoServiceProvider aesCSP = new AesCryptoServiceProvider()) {
                aesCSP.BlockSize = 128;
                aesCSP.Padding = PaddingMode.PKCS7;
                aesCSP.Key = K;
                aesCSP.IV = IV;

                ICryptoTransform encryptor = aesCSP.CreateEncryptor(aesCSP.Key, aesCSP.IV);

                using (MemoryStream msEnc = new MemoryStream())
                using (CryptoStream csEnc = new CryptoStream(msEnc, encryptor, CryptoStreamMode.Write))
                    cipher = encryptor.TransformFinalBlock(encrypted, 0, encrypted.Length);
            }
            return cipher;
        }
    }
}
