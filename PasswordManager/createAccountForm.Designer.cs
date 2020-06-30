namespace PasswordManager {
    partial class createAccountForm {
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
            this.emailLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.submitAccountButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.usernameErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.confirmPassLabel = new System.Windows.Forms.Label();
            this.confirmPassBox = new System.Windows.Forms.TextBox();
            this.confirmPassErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(97, 99);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(97, 149);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // passBox
            // 
            this.passBox.AutoSize = true;
            this.passBox.Location = new System.Drawing.Point(97, 195);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(53, 13);
            this.passBox.TabIndex = 2;
            this.passBox.Text = "Password";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(100, 119);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(195, 20);
            this.emailBox.TabIndex = 4;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(100, 165);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(195, 20);
            this.usernameBox.TabIndex = 5;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(100, 211);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(195, 20);
            this.passwordBox.TabIndex = 6;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // submitAccountButton
            // 
            this.submitAccountButton.Location = new System.Drawing.Point(100, 305);
            this.submitAccountButton.Name = "submitAccountButton";
            this.submitAccountButton.Size = new System.Drawing.Size(75, 23);
            this.submitAccountButton.TabIndex = 8;
            this.submitAccountButton.Text = "Submit";
            this.submitAccountButton.UseVisualStyleBackColor = true;
            this.submitAccountButton.Click += new System.EventHandler(this.submitAccountButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(97, 71);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 9;
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.Location = new System.Drawing.Point(87, 122);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.emailErrorLabel.TabIndex = 10;
            // 
            // usernameErrorLabel
            // 
            this.usernameErrorLabel.AutoSize = true;
            this.usernameErrorLabel.Location = new System.Drawing.Point(87, 168);
            this.usernameErrorLabel.Name = "usernameErrorLabel";
            this.usernameErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.usernameErrorLabel.TabIndex = 11;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.Location = new System.Drawing.Point(87, 214);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.passwordErrorLabel.TabIndex = 12;
            // 
            // confirmPassLabel
            // 
            this.confirmPassLabel.AutoSize = true;
            this.confirmPassLabel.Location = new System.Drawing.Point(97, 241);
            this.confirmPassLabel.Name = "confirmPassLabel";
            this.confirmPassLabel.Size = new System.Drawing.Size(91, 13);
            this.confirmPassLabel.TabIndex = 3;
            this.confirmPassLabel.Text = "Confirm Password";
            // 
            // confirmPassBox
            // 
            this.confirmPassBox.Location = new System.Drawing.Point(100, 258);
            this.confirmPassBox.Name = "confirmPassBox";
            this.confirmPassBox.Size = new System.Drawing.Size(195, 20);
            this.confirmPassBox.TabIndex = 7;
            this.confirmPassBox.TextChanged += new System.EventHandler(this.confirmPassBox_TextChanged);
            // 
            // confirmPassErrorLabel
            // 
            this.confirmPassErrorLabel.AutoSize = true;
            this.confirmPassErrorLabel.Location = new System.Drawing.Point(87, 261);
            this.confirmPassErrorLabel.Name = "confirmPassErrorLabel";
            this.confirmPassErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.confirmPassErrorLabel.TabIndex = 13;
            // 
            // createAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.confirmPassErrorLabel);
            this.Controls.Add(this.passwordErrorLabel);
            this.Controls.Add(this.usernameErrorLabel);
            this.Controls.Add(this.emailErrorLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.submitAccountButton);
            this.Controls.Add(this.confirmPassBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.confirmPassLabel);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.emailLabel);
            this.Name = "createAccountForm";
            this.Text = "createAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button submitAccountButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label emailErrorLabel;
        private System.Windows.Forms.Label usernameErrorLabel;
        private System.Windows.Forms.Label passwordErrorLabel;
        private System.Windows.Forms.Label confirmPassLabel;
        private System.Windows.Forms.TextBox confirmPassBox;
        private System.Windows.Forms.Label confirmPassErrorLabel;
    }
}