namespace PasswordManager {
    partial class dbConfig {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbConfig));
            this.labelDatabaseIP = new System.Windows.Forms.Label();
            this.labelDatabaseUser = new System.Windows.Forms.Label();
            this.labelDatabasePassword = new System.Windows.Forms.Label();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.textBoxDatabaseIP = new System.Windows.Forms.TextBox();
            this.textBoxDatabaseUser = new System.Windows.Forms.TextBox();
            this.textBoxDatabasePassword = new System.Windows.Forms.TextBox();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.labelConfigConfirm = new System.Windows.Forms.Button();
            this.labelConfigCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDatabaseIP
            // 
            this.labelDatabaseIP.AutoSize = true;
            this.labelDatabaseIP.Location = new System.Drawing.Point(121, 100);
            this.labelDatabaseIP.Name = "labelDatabaseIP";
            this.labelDatabaseIP.Size = new System.Drawing.Size(103, 13);
            this.labelDatabaseIP.TabIndex = 0;
            this.labelDatabaseIP.Text = "Database Server IP:";
            // 
            // labelDatabaseUser
            // 
            this.labelDatabaseUser.AutoSize = true;
            this.labelDatabaseUser.Location = new System.Drawing.Point(121, 160);
            this.labelDatabaseUser.Name = "labelDatabaseUser";
            this.labelDatabaseUser.Size = new System.Drawing.Size(81, 13);
            this.labelDatabaseUser.TabIndex = 1;
            this.labelDatabaseUser.Text = "Database User:";
            // 
            // labelDatabasePassword
            // 
            this.labelDatabasePassword.AutoSize = true;
            this.labelDatabasePassword.Location = new System.Drawing.Point(121, 220);
            this.labelDatabasePassword.Name = "labelDatabasePassword";
            this.labelDatabasePassword.Size = new System.Drawing.Size(105, 13);
            this.labelDatabasePassword.TabIndex = 2;
            this.labelDatabasePassword.Text = "Database Password:";
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Location = new System.Drawing.Point(121, 280);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(88, 13);
            this.labelDatabase.TabIndex = 3;
            this.labelDatabase.Text = "Database to use:";
            // 
            // textBoxDatabaseIP
            // 
            this.textBoxDatabaseIP.Location = new System.Drawing.Point(124, 116);
            this.textBoxDatabaseIP.Name = "textBoxDatabaseIP";
            this.textBoxDatabaseIP.Size = new System.Drawing.Size(200, 20);
            this.textBoxDatabaseIP.TabIndex = 4;
            // 
            // textBoxDatabaseUser
            // 
            this.textBoxDatabaseUser.Location = new System.Drawing.Point(124, 176);
            this.textBoxDatabaseUser.Name = "textBoxDatabaseUser";
            this.textBoxDatabaseUser.Size = new System.Drawing.Size(200, 20);
            this.textBoxDatabaseUser.TabIndex = 5;
            // 
            // textBoxDatabasePassword
            // 
            this.textBoxDatabasePassword.Location = new System.Drawing.Point(124, 236);
            this.textBoxDatabasePassword.Name = "textBoxDatabasePassword";
            this.textBoxDatabasePassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxDatabasePassword.TabIndex = 6;
            this.textBoxDatabasePassword.TextChanged += new System.EventHandler(this.textBoxDatabasePassword_TextChanged);
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(124, 296);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(200, 20);
            this.textBoxDatabase.TabIndex = 7;
            // 
            // labelConfigConfirm
            // 
            this.labelConfigConfirm.Location = new System.Drawing.Point(124, 349);
            this.labelConfigConfirm.Name = "labelConfigConfirm";
            this.labelConfigConfirm.Size = new System.Drawing.Size(85, 23);
            this.labelConfigConfirm.TabIndex = 8;
            this.labelConfigConfirm.Text = "Confirm";
            this.labelConfigConfirm.UseVisualStyleBackColor = true;
            this.labelConfigConfirm.Click += new System.EventHandler(this.labelConfigConfirm_Click);
            // 
            // labelConfigCancel
            // 
            this.labelConfigCancel.Location = new System.Drawing.Point(239, 349);
            this.labelConfigCancel.Name = "labelConfigCancel";
            this.labelConfigCancel.Size = new System.Drawing.Size(85, 23);
            this.labelConfigCancel.TabIndex = 9;
            this.labelConfigCancel.Text = "Cancel";
            this.labelConfigCancel.UseVisualStyleBackColor = true;
            this.labelConfigCancel.Click += new System.EventHandler(this.labelConfigCancel_Click);
            // 
            // dbConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.labelConfigCancel);
            this.Controls.Add(this.labelConfigConfirm);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.textBoxDatabasePassword);
            this.Controls.Add(this.textBoxDatabaseUser);
            this.Controls.Add(this.textBoxDatabaseIP);
            this.Controls.Add(this.labelDatabase);
            this.Controls.Add(this.labelDatabasePassword);
            this.Controls.Add(this.labelDatabaseUser);
            this.Controls.Add(this.labelDatabaseIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dbConfig";
            this.Text = "dbConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDatabaseIP;
        private System.Windows.Forms.Label labelDatabaseUser;
        private System.Windows.Forms.Label labelDatabasePassword;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.TextBox textBoxDatabaseIP;
        private System.Windows.Forms.TextBox textBoxDatabaseUser;
        private System.Windows.Forms.TextBox textBoxDatabasePassword;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Button labelConfigConfirm;
        private System.Windows.Forms.Button labelConfigCancel;
    }
}