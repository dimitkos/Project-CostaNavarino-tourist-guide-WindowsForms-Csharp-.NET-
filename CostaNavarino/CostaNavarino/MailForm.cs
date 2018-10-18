using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace CostaNavarino
{
    public partial class MailForm : Form1
    {
        //δηλωνουμε μια αναφορα τυπου MailMessage
        MailMessage msg;
        public MailForm()
        {
            InitializeComponent();
        }

        private void MailForm_Load(object sender, EventArgs e)
        {

        }

        private void MailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //για τις αναγκες της παρουσας εργασιας φτιαξαμε ενα mail projectsunipi@gmail.com.
            //για λογους ασφαλειας επιλεξαμε μην βαζει ακποιος το κανονικο μεηλ του και τους κωδικους του
            //ετσι λοιπον οτι μεηλ και να γραψει στο textbox θα φυγει και θα παραληφθει απο το παραπανω μεηλ

            MailSender msender = new MailSender();

            msender.Sendmail(textBox1, textBox2);

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip1.Show("Στείλτε το μήνυμα σας ", button1);
        }
    }
}
