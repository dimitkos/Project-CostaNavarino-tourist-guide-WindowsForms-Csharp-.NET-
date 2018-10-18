﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostaNavarino
{
    public partial class ActivitiesForm : Form1
    {
        public ActivitiesForm()
        {
            InitializeComponent();
        }

        private void ActivitiesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ayth h forma kryvetai kai sthn synexeia leei sthn forma poy thn dhmiourghse na emfanistei
            this.Hide();
            Owner.Show();
        }

        private void ActivitiesForm_Load(object sender, EventArgs e)
        {
            //το περιεχομενο του ειναι μονο για αναγνωση
            richTextBox1.ReadOnly = true;
        }

        private void exportactbutton_Click(object sender, EventArgs e)
        {
            //φτιαχνουμε ενα αντικειμενο τυπου txt και καλουμε την μεθοδο ετσι ωστε να παρει τις πληροφοριες απο το 
            //richtextbox  και να τις γραψει σε ενα txt
            Txt actfile = new Txt("activities.txt");
            actfile.WriteTxt(richTextBox1);
            actfile.SuccessWriteTxt();
        }

        private void exportactbutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip1.Show("Αποθηκεύστε τις πληροφοριες στον υπολογιστη σας", exportactbutton);
        }
    }
}
