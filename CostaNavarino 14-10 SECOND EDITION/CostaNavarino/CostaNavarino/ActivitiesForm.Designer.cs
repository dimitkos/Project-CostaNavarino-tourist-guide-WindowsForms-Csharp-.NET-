namespace CostaNavarino
{
    partial class ActivitiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivitiesForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.exportactbutton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(426, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(338, 250);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // exportactbutton
            // 
            this.exportactbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportactbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportactbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.exportactbutton.Location = new System.Drawing.Point(537, 387);
            this.exportactbutton.Name = "exportactbutton";
            this.exportactbutton.Size = new System.Drawing.Size(89, 23);
            this.exportactbutton.TabIndex = 2;
            this.exportactbutton.Text = "Αποθήκευση";
            this.exportactbutton.UseVisualStyleBackColor = true;
            this.exportactbutton.Click += new System.EventHandler(this.exportactbutton_Click);
            this.exportactbutton.MouseHover += new System.EventHandler(this.exportactbutton_MouseHover);
            // 
            // ActivitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exportactbutton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ActivitiesForm";
            this.Text = "ActivitiesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActivitiesForm_FormClosing);
            this.Load += new System.EventHandler(this.ActivitiesForm_Load);
            this.Controls.SetChildIndex(this.richTextBox1, 0);
            this.Controls.SetChildIndex(this.exportactbutton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button exportactbutton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}