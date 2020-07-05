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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPane));
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
            this.addEntryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginPanel.SuspendLayout();
            this.dashboardPanel.SuspendLayout();
            this.columnControlBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameBox.Location = new System.Drawing.Point(600, 235);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(195, 20);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameBox_KeyPress);
            // 
            // userLabel
            // 
            this.userLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(597, 219);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(55, 13);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Username";
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.Location = new System.Drawing.Point(600, 292);
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
            this.passLabel.Location = new System.Drawing.Point(597, 276);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(53, 13);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Location = new System.Drawing.Point(600, 337);
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
            this.createAccountLabel.Location = new System.Drawing.Point(694, 346);
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
            this.loginPanel.Controls.Add(this.menuStrip2);
            this.loginPanel.Location = new System.Drawing.Point(-2, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1395, 562);
            this.loginPanel.TabIndex = 7;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Controls.Add(this.columnControlBox);
            this.dashboardPanel.Controls.Add(this.menuStrip1);
            this.dashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(1400, 562);
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
            this.columnControlBox.Size = new System.Drawing.Size(1393, 23);
            this.columnControlBox.TabIndex = 1;
            this.columnControlBox.TabStop = false;
            // 
            // passwordSortButton
            // 
            this.passwordSortButton.Location = new System.Drawing.Point(975, 0);
            this.passwordSortButton.Margin = new System.Windows.Forms.Padding(0);
            this.passwordSortButton.Name = "passwordSortButton";
            this.passwordSortButton.Size = new System.Drawing.Size(418, 23);
            this.passwordSortButton.TabIndex = 3;
            this.passwordSortButton.Text = "Password";
            this.passwordSortButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordSortButton.UseVisualStyleBackColor = true;
            // 
            // usernameSortButton
            // 
            this.usernameSortButton.Location = new System.Drawing.Point(648, 0);
            this.usernameSortButton.Margin = new System.Windows.Forms.Padding(0);
            this.usernameSortButton.Name = "usernameSortButton";
            this.usernameSortButton.Size = new System.Drawing.Size(328, 23);
            this.usernameSortButton.TabIndex = 2;
            this.usernameSortButton.Text = "Username";
            this.usernameSortButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameSortButton.UseVisualStyleBackColor = true;
            // 
            // emailSortButton
            // 
            this.emailSortButton.Location = new System.Drawing.Point(304, 0);
            this.emailSortButton.Margin = new System.Windows.Forms.Padding(0);
            this.emailSortButton.Name = "emailSortButton";
            this.emailSortButton.Size = new System.Drawing.Size(345, 23);
            this.emailSortButton.TabIndex = 1;
            this.emailSortButton.Text = "Email";
            this.emailSortButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emailSortButton.UseVisualStyleBackColor = true;
            // 
            // serviceSortButton
            // 
            this.serviceSortButton.Location = new System.Drawing.Point(0, 0);
            this.serviceSortButton.Margin = new System.Windows.Forms.Padding(0);
            this.serviceSortButton.Name = "serviceSortButton";
            this.serviceSortButton.Size = new System.Drawing.Size(305, 23);
            this.serviceSortButton.TabIndex = 0;
            this.serviceSortButton.Text = "Service";
            this.serviceSortButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceSortButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEntryButton,
            this.refreshDashboard});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1400, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addEntryButton
            // 
            this.addEntryButton.Image = ((System.Drawing.Image)(resources.GetObject("addEntryButton.Image")));
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(28, 20);
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // refreshDashboard
            // 
            this.refreshDashboard.Image = ((System.Drawing.Image)(resources.GetObject("refreshDashboard.Image")));
            this.refreshDashboard.Name = "refreshDashboard";
            this.refreshDashboard.Size = new System.Drawing.Size(28, 20);
            this.refreshDashboard.Click += new System.EventHandler(this.refreshDashboard_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1395, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseConfigurationToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // databaseConfigurationToolStripMenuItem
            // 
            this.databaseConfigurationToolStripMenuItem.Name = "databaseConfigurationToolStripMenuItem";
            this.databaseConfigurationToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.databaseConfigurationToolStripMenuItem.Text = "Database Configuration";
            this.databaseConfigurationToolStripMenuItem.Click += new System.EventHandler(this.databaseConfigurationToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // MainPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 561);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.dashboardPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
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
        private System.Windows.Forms.Button serviceSortButton;
        private System.Windows.Forms.Button passwordSortButton;
        private System.Windows.Forms.Button usernameSortButton;
        private System.Windows.Forms.Button emailSortButton;
        private System.Windows.Forms.ToolStripMenuItem addEntryButton;
        private System.Windows.Forms.ToolStripMenuItem refreshDashboard;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
    }
}

