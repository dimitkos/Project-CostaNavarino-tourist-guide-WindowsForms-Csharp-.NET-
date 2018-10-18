namespace CostaNavarino
{
    partial class VisitorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorForm));
            this.slideshowBox = new System.Windows.Forms.PictureBox();
            this.Destinationbutton = new System.Windows.Forms.Button();
            this.Mapbutton = new System.Windows.Forms.Button();
            this.Calendarbutton = new System.Windows.Forms.Button();
            this.Golfbutton = new System.Windows.Forms.Button();
            this.Activitiesbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.ResetHistorybutton = new System.Windows.Forms.Button();
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slideshowBox)).BeginInit();
            this.SuspendLayout();
            // 
            // slideshowBox
            // 
            this.slideshowBox.Image = global::CostaNavarino.Properties.Resources.voidokoilia2;
            this.slideshowBox.Location = new System.Drawing.Point(23, 52);
            this.slideshowBox.Name = "slideshowBox";
            this.slideshowBox.Size = new System.Drawing.Size(765, 228);
            this.slideshowBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slideshowBox.TabIndex = 1;
            this.slideshowBox.TabStop = false;
            // 
            // Destinationbutton
            // 
            this.Destinationbutton.BackColor = System.Drawing.Color.Transparent;
            this.Destinationbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Destinationbutton.FlatAppearance.BorderSize = 0;
            this.Destinationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Destinationbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Destinationbutton.Location = new System.Drawing.Point(17, 338);
            this.Destinationbutton.Name = "Destinationbutton";
            this.Destinationbutton.Size = new System.Drawing.Size(79, 82);
            this.Destinationbutton.TabIndex = 2;
            this.Destinationbutton.Text = "Destination";
            this.Destinationbutton.UseVisualStyleBackColor = false;
            this.Destinationbutton.Click += new System.EventHandler(this.button1_Click);
            this.Destinationbutton.MouseHover += new System.EventHandler(this.Destinationbutton_MouseHover);
            // 
            // Mapbutton
            // 
            this.Mapbutton.BackColor = System.Drawing.Color.Transparent;
            this.Mapbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mapbutton.FlatAppearance.BorderSize = 0;
            this.Mapbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mapbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Mapbutton.Location = new System.Drawing.Point(157, 337);
            this.Mapbutton.Name = "Mapbutton";
            this.Mapbutton.Size = new System.Drawing.Size(75, 82);
            this.Mapbutton.TabIndex = 3;
            this.Mapbutton.Text = "Map";
            this.Mapbutton.UseVisualStyleBackColor = false;
            this.Mapbutton.Click += new System.EventHandler(this.button2_Click);
            this.Mapbutton.MouseHover += new System.EventHandler(this.Mapbutton_MouseHover);
            // 
            // Calendarbutton
            // 
            this.Calendarbutton.BackColor = System.Drawing.Color.Transparent;
            this.Calendarbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calendarbutton.FlatAppearance.BorderSize = 0;
            this.Calendarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Calendarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Calendarbutton.Location = new System.Drawing.Point(293, 338);
            this.Calendarbutton.Name = "Calendarbutton";
            this.Calendarbutton.Size = new System.Drawing.Size(78, 82);
            this.Calendarbutton.TabIndex = 4;
            this.Calendarbutton.Text = "Calendar";
            this.Calendarbutton.UseVisualStyleBackColor = false;
            this.Calendarbutton.Click += new System.EventHandler(this.button3_Click);
            this.Calendarbutton.MouseHover += new System.EventHandler(this.Calendarbutton_MouseHover);
            // 
            // Golfbutton
            // 
            this.Golfbutton.BackColor = System.Drawing.Color.Transparent;
            this.Golfbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Golfbutton.FlatAppearance.BorderSize = 0;
            this.Golfbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Golfbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Golfbutton.Location = new System.Drawing.Point(436, 338);
            this.Golfbutton.Name = "Golfbutton";
            this.Golfbutton.Size = new System.Drawing.Size(75, 82);
            this.Golfbutton.TabIndex = 5;
            this.Golfbutton.Text = "Golf";
            this.Golfbutton.UseVisualStyleBackColor = false;
            this.Golfbutton.Click += new System.EventHandler(this.Golfbutton_Click);
            this.Golfbutton.MouseHover += new System.EventHandler(this.Golfbutton_MouseHover);
            // 
            // Activitiesbutton
            // 
            this.Activitiesbutton.BackColor = System.Drawing.Color.Transparent;
            this.Activitiesbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Activitiesbutton.FlatAppearance.BorderSize = 0;
            this.Activitiesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Activitiesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Activitiesbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Activitiesbutton.Location = new System.Drawing.Point(574, 338);
            this.Activitiesbutton.Name = "Activitiesbutton";
            this.Activitiesbutton.Size = new System.Drawing.Size(75, 82);
            this.Activitiesbutton.TabIndex = 6;
            this.Activitiesbutton.Text = "Activities";
            this.Activitiesbutton.UseVisualStyleBackColor = false;
            this.Activitiesbutton.Click += new System.EventHandler(this.button5_Click);
            this.Activitiesbutton.MouseHover += new System.EventHandler(this.Activitiesbutton_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ResetHistorybutton
            // 
            this.ResetHistorybutton.BackColor = System.Drawing.Color.Transparent;
            this.ResetHistorybutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetHistorybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ResetHistorybutton.Location = new System.Drawing.Point(696, 348);
            this.ResetHistorybutton.Name = "ResetHistorybutton";
            this.ResetHistorybutton.Size = new System.Drawing.Size(82, 45);
            this.ResetHistorybutton.TabIndex = 7;
            this.ResetHistorybutton.Text = "Reset History";
            this.ResetHistorybutton.UseVisualStyleBackColor = false;
            this.ResetHistorybutton.Click += new System.EventHandler(this.ResetHistorybutton_Click);
            this.ResetHistorybutton.MouseHover += new System.EventHandler(this.ResetHistorybutton_MouseHover);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.Location = new System.Drawing.Point(696, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Mute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VisitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResetHistorybutton);
            this.Controls.Add(this.Activitiesbutton);
            this.Controls.Add(this.Golfbutton);
            this.Controls.Add(this.Calendarbutton);
            this.Controls.Add(this.Mapbutton);
            this.Controls.Add(this.Destinationbutton);
            this.Controls.Add(this.slideshowBox);
            this.Name = "VisitorForm";
            this.Text = "VisitorForm";
            this.Activated += new System.EventHandler(this.VisitorForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisitorForm_FormClosing);
            this.Load += new System.EventHandler(this.VisitorForm_Load);
            this.Controls.SetChildIndex(this.slideshowBox, 0);
            this.Controls.SetChildIndex(this.Destinationbutton, 0);
            this.Controls.SetChildIndex(this.Mapbutton, 0);
            this.Controls.SetChildIndex(this.Calendarbutton, 0);
            this.Controls.SetChildIndex(this.Golfbutton, 0);
            this.Controls.SetChildIndex(this.Activitiesbutton, 0);
            this.Controls.SetChildIndex(this.ResetHistorybutton, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.slideshowBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slideshowBox;
        private System.Windows.Forms.Button Destinationbutton;
        private System.Windows.Forms.Button Mapbutton;
        private System.Windows.Forms.Button Calendarbutton;
        private System.Windows.Forms.Button Golfbutton;
        private System.Windows.Forms.Button Activitiesbutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.Button ResetHistorybutton;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
    }
}