using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PasswordManager {
    public partial class dbConfig : Form {
        string db_ip, db_user, db_pass, db_database;
        string dbConfPath = ".\\db.conf";

        public dbConfig() {
            InitializeComponent();
        }

        public (string, string, string, string) getDBCreds() {
            return (db_ip, db_user, db_pass, db_database);
        }

        private void textBoxDatabasePassword_TextChanged(object sender, EventArgs e) {
            textBoxDatabasePassword.PasswordChar = '*';
        }

        private void labelConfigConfirm_Click(object sender, EventArgs e) {
            db_ip = textBoxDatabaseIP.Text;
            db_user = textBoxDatabaseUser.Text;
            db_pass = textBoxDatabasePassword.Text;
            db_database = textBoxDatabase.Text;

            if (File.Exists(dbConfPath)) File.Delete(dbConfPath);

            using (StreamWriter fs = File.CreateText(dbConfPath)) {
                fs.WriteLine(db_ip);
                fs.WriteLine(db_user);
                fs.WriteLine(db_pass);
                fs.WriteLine(db_database);

                fs.Close();
            }

            this.Close();
        }

        private void labelConfigCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
