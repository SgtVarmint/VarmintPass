namespace PasswordManager {
    partial class MainPane {
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
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.invalidLoginLabel = new System.Windows.Forms.Label();
            this.createAccountLabel = new System.Windows.Forms.LinkLabel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.columnControlBox = new System.Windows.Forms.GroupBox();
            this.passwordSortButton = new System.Windows.Forms.Button();
            this.usernameSortButton = new System.Windows.Forms.Button();
            this.emailSortButton = new System.Windows.Forms.Button();
            this.serviceSortButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginPanel.SuspendLayout();
            this.dashboardPanel.SuspendLayout();
            this.columnControlBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameBox.Location = new System.Drawing.Point(306, 180);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(195, 20);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameBox_KeyPress);
            // 
            // userLabel
            // 
            this.userLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(303, 164);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(55, 13);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Username";
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.Location = new System.Drawing.Point(306, 237);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(195, 20);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            this.passwordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordBox_KeyPress);
            // 
            // passLabel
            // 
            this.passLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(303, 221);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(53, 13);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Location = new System.Drawing.Point(306, 282);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // invalidLoginLabel
            // 
            this.invalidLoginLabel.AutoSize = true;
            this.invalidLoginLabel.Location = new System.Drawing.Point(303, 141);
            this.invalidLoginLabel.Name = "invalidLoginLabel";
            this.invalidLoginLabel.Size = new System.Drawing.Size(0, 13);
            this.invalidLoginLabel.TabIndex = 5;
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Location = new System.Drawing.Point(400, 291);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(95, 13);
            this.createAccountLabel.TabIndex = 6;
            this.createAccountLabel.TabStop = true;
            this.createAccountLabel.Text = "Create an account";
            this.createAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccountLabel_LinkClicked);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.userLabel);
            this.loginPanel.Controls.Add(this.createAccountLabel);
            this.loginPanel.Controls.Add(this.usernameBox);
            this.loginPanel.Controls.Add(this.invalidLoginLabel);
            this.loginPanel.Controls.Add(this.passwordBox);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.passLabel);
            this.loginPanel.Location = new System.Drawing.Point(-2, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(806, 453);
            this.loginPanel.TabIndex = 7;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Controls.Add(this.columnControlBox);
            this.dashboardPanel.Controls.Add(this.menuStrip1);
            this.dashboardPanel.Location = new System.Drawing.Point(-2, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(806, 453);
            this.dashboardPanel.TabIndex = 8;
            // 
            // columnControlBox
            // 
            this.columnControlBox.Controls.Add(this.passwordSortButton);
            this.columnControlBox.Controls.Add(this.usernameSortButton);
            this.columnControlBox.Controls.Add(this.emailSortButton);
            this.columnControlBox.Controls.Add(this.serviceSortButton);
            this.columnControlBox.Location = new System.Drawing.Point(0, 25);
            this.columnControlBox.Name = "columnControlBox";
            this.columnControlBox.Size = new System.Drawing.Size(800, 23);
            this.columnControlBox.TabIndex = 1;
            this.columnControlBox.TabStop = false;
            // 
            // passwordSortButton
            // 
            this.passwordSortButton.Location = new System.Drawing.Point(510, 0);
            this.passwordSortButton.Name = "passwordSortButton";
            this.passwordSortButton.Size = new System.Drawing.Size(290, 23);
            this.passwordSortButton.TabIndex = 3;
            this.passwordSortButton.Text = "Password";
            this.passwordSortButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordSortButton.UseVisualStyleBackColor = true;
            // 
            // usernameSortButton
            // 
            this.usernameSortButton.Location = new System.Drawing.Point(286, 0);
            this.usernameSortButton.Name = "usernameSortButton";
            this.usernameSortButton.Size = new System.Drawing.Size(225, 23);
            this.usernameSortButton.TabIndex = 2;
            this.usernameSortButton.Text = "Username";
            this.usernameSortButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameSortButton.UseVisualStyleBackColor = true;
            // 
            // emailSortButton
            // 
            this.emailSortButton.Location = new System.Drawing.Point(137, 0);
            this.emailSortButton.Name = "emailSortButton";
            this.emailSortButton.Size = new System.Drawing.Size(150, 23);
            this.emailSortButton.TabIndex = 1;
            this.emailSortButton.Text = "Email";
            this.emailSortButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emailSortButton.UseVisualStyleBackColor = true;
            // 
            // serviceSortButton
            // 
            this.serviceSortButton.Location = new System.Drawing.Point(2, 0);
            this.serviceSortButton.Name = "serviceSortButton";
            this.serviceSortButton.Size = new System.Drawing.Size(140, 23);
            this.serviceSortButton.TabIndex = 0;
            this.serviceSortButton.Text = "Service";
            this.serviceSortButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceSortButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // MainPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.dashboardPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPane";
            this.Text = "Varmint Pass";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.dashboardPanel.ResumeLayout(false);
            this.dashboardPanel.PerformLayout();
            this.columnControlBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label invalidLoginLabel;
        private System.Windows.Forms.LinkLabel createAccountLabel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.GroupBox columnControlBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Button serviceSortButton;
        private System.Windows.Forms.Button passwordSortButton;
        private System.Windows.Forms.Button usernameSortButton;
        private System.Windows.Forms.Button emailSortButton;
    }
}

