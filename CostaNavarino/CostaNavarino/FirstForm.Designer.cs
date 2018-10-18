namespace CostaNavarino
{
    partial class FirstForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.visitButton = new System.Windows.Forms.Button();
            this.costanavarinoSiteLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginButtonPanel = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Location = new System.Drawing.Point(602, 352);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(191, 33);
            this.loginButton.TabIndex = 2;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.MouseHover += new System.EventHandler(this.loginButton_MouseHover);
            // 
            // visitButton
            // 
            this.visitButton.BackColor = System.Drawing.Color.Transparent;
            this.visitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visitButton.FlatAppearance.BorderSize = 0;
            this.visitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.visitButton.Location = new System.Drawing.Point(602, 316);
            this.visitButton.Name = "visitButton";
            this.visitButton.Size = new System.Drawing.Size(191, 35);
            this.visitButton.TabIndex = 3;
            this.visitButton.UseVisualStyleBackColor = false;
            this.visitButton.Click += new System.EventHandler(this.visitButton_Click);
            this.visitButton.MouseHover += new System.EventHandler(this.visitButton_MouseHover);
            // 
            // costanavarinoSiteLabel
            // 
            this.costanavarinoSiteLabel.AutoSize = true;
            this.costanavarinoSiteLabel.BackColor = System.Drawing.Color.Transparent;
            this.costanavarinoSiteLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.costanavarinoSiteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.costanavarinoSiteLabel.ForeColor = System.Drawing.Color.White;
            this.costanavarinoSiteLabel.Location = new System.Drawing.Point(361, 375);
            this.costanavarinoSiteLabel.Name = "costanavarinoSiteLabel";
            this.costanavarinoSiteLabel.Size = new System.Drawing.Size(83, 13);
            this.costanavarinoSiteLabel.TabIndex = 4;
            this.costanavarinoSiteLabel.Text = "Visit our website";
            this.costanavarinoSiteLabel.Click += new System.EventHandler(this.costanavarinoSiteLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.loginButtonPanel);
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.Controls.Add(this.userNameTextBox);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Location = new System.Drawing.Point(184, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 164);
            this.panel1.TabIndex = 5;
            // 
            // loginButtonPanel
            // 
            this.loginButtonPanel.BackColor = System.Drawing.Color.SaddleBrown;
            this.loginButtonPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButtonPanel.FlatAppearance.BorderSize = 0;
            this.loginButtonPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButtonPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginButtonPanel.ForeColor = System.Drawing.Color.White;
            this.loginButtonPanel.Location = new System.Drawing.Point(170, 105);
            this.loginButtonPanel.Name = "loginButtonPanel";
            this.loginButtonPanel.Size = new System.Drawing.Size(64, 29);
            this.loginButtonPanel.TabIndex = 4;
            this.loginButtonPanel.Text = "Login";
            this.loginButtonPanel.UseVisualStyleBackColor = false;
            this.loginButtonPanel.Click += new System.EventHandler(this.loginButtonPanel_Click);
            this.loginButtonPanel.MouseHover += new System.EventHandler(this.loginButtonPanel_MouseHover);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(157, 70);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(157, 17);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordLabel.Location = new System.Drawing.Point(60, 68);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(86, 20);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usernameLabel.Location = new System.Drawing.Point(60, 17);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(91, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.costanavarinoSiteLabel);
            this.Controls.Add(this.visitButton);
            this.Controls.Add(this.loginButton);
            this.Name = "FirstForm";
            this.Text = "FirstForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstForm_FormClosing);
            this.Load += new System.EventHandler(this.FirstForm_Load);
            this.Controls.SetChildIndex(this.loginButton, 0);
            this.Controls.SetChildIndex(this.visitButton, 0);
            this.Controls.SetChildIndex(this.costanavarinoSiteLabel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button visitButton;
        private System.Windows.Forms.Label costanavarinoSiteLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button loginButtonPanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}