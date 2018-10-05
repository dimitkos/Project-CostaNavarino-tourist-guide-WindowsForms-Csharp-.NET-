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
            this.costanavarinoLabel = new System.Windows.Forms.Label();
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
            // costanavarinoLabel
            // 
            this.costanavarinoLabel.AutoSize = true;
            this.costanavarinoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costanavarinoLabel.Location = new System.Drawing.Point(232, 54);
            this.costanavarinoLabel.Name = "costanavarinoLabel";
            this.costanavarinoLabel.Size = new System.Drawing.Size(334, 25);
            this.costanavarinoLabel.TabIndex = 1;
            this.costanavarinoLabel.Text = "Costa Navariono Grand Resort";
            this.costanavarinoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(27, 113);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "User";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.MouseHover += new System.EventHandler(this.loginButton_MouseHover);
            // 
            // visitButton
            // 
            this.visitButton.Location = new System.Drawing.Point(27, 142);
            this.visitButton.Name = "visitButton";
            this.visitButton.Size = new System.Drawing.Size(75, 23);
            this.visitButton.TabIndex = 3;
            this.visitButton.Text = "Visitor";
            this.visitButton.UseVisualStyleBackColor = true;
            this.visitButton.Click += new System.EventHandler(this.visitButton_Click);
            this.visitButton.MouseHover += new System.EventHandler(this.visitButton_MouseHover);
            // 
            // costanavarinoSiteLabel
            // 
            this.costanavarinoSiteLabel.AutoSize = true;
            this.costanavarinoSiteLabel.Location = new System.Drawing.Point(680, 365);
            this.costanavarinoSiteLabel.Name = "costanavarinoSiteLabel";
            this.costanavarinoSiteLabel.Size = new System.Drawing.Size(113, 13);
            this.costanavarinoSiteLabel.TabIndex = 4;
            this.costanavarinoSiteLabel.Text = "www.costanavarino.gr";
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
            this.loginButtonPanel.Location = new System.Drawing.Point(168, 117);
            this.loginButtonPanel.Name = "loginButtonPanel";
            this.loginButtonPanel.Size = new System.Drawing.Size(75, 23);
            this.loginButtonPanel.TabIndex = 4;
            this.loginButtonPanel.Text = "Login";
            this.loginButtonPanel.UseVisualStyleBackColor = true;
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
            this.passwordLabel.Location = new System.Drawing.Point(84, 70);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(84, 20);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
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
            this.Controls.Add(this.costanavarinoLabel);
            this.Controls.Add(this.visitButton);
            this.Controls.Add(this.loginButton);
            this.Name = "FirstForm";
            this.Text = "FirstForm";
            this.Load += new System.EventHandler(this.FirstForm_Load);
            this.Controls.SetChildIndex(this.loginButton, 0);
            this.Controls.SetChildIndex(this.visitButton, 0);
            this.Controls.SetChildIndex(this.costanavarinoLabel, 0);
            this.Controls.SetChildIndex(this.costanavarinoSiteLabel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label costanavarinoLabel;
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