using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostaNavarino
{
    public partial class DestinationForm : Form1
    {
        public DestinationForm()
        {
            InitializeComponent();
        }

        private void DestinationForm_Load(object sender, EventArgs e)
        {

        }

        private void DestinationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ayth h forma kryvetai kai sthn synexeia leei sthn forma poy thn dhmiourghse na emfanistei
            this.Hide();
            Owner.Show();
        }
    }
}
