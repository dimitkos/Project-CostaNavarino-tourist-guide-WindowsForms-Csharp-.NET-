using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostaNavarino
{
    public partial class MapForm : Form1
    {
        public MapForm()
        {
            InitializeComponent();
            //αρχικοποιουμε οτι το richTextBox1 θα ειναι μονο για αναγνωση και οχ ρηστης δεν θα μπορει να σβησει η να γραψει εκει
            richTextBox1.ReadOnly = true;
        }

        private void MapForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ayth h forma kryvetai kai sthn synexeia leei sthn forma poy thn dhmiourghse na emfanistei
            this.Hide();
            Owner.Show();
        }

        private void MapForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //με το που πατησουμε το κουμπι  τοτε μας παει στην ιστσελιδα

            //φτιαχνουμε ενα αντικειμενο τυπου InternetPage οπου μεσα στον κονστρακτορα βαζουλε το λινκ που θα εχει

            InternetPage newpage = new InternetPage("https://gr.pinterest.com/costanavarino/");

            //στην συνεχεια καλουμε την μεθοδο ωστς να ανοιξει η ιστοσελιδα
            newpage.OpenWebPage();
            
        }

        private void fbbutton_Click(object sender, EventArgs e)
        {
            //με το που πατησουμε το κουμπι  τοτε μας παει στην ιστσελιδα

            //φτιαχνουμε ενα αντικειμενο τυπου InternetPage οπου μεσα στον κονστρακτορα βαζουλε το λινκ που θα εχει

            InternetPage newpage = new InternetPage("https://www.facebook.com/costanavarino/");

            //στην συνεχεια καλουμε την μεθοδο ωστς να ανοιξει η ιστοσελιδα
            newpage.OpenWebPage();

        }

        private void instabutton_Click(object sender, EventArgs e)
        {
            //με το που πατησουμε το κουμπι  τοτε μας παει στην ιστσελιδα

            //φτιαχνουμε ενα αντικειμενο τυπου InternetPage οπου μεσα στον κονστρακτορα βαζουλε το λινκ που θα εχει

            InternetPage newpage = new InternetPage("https://www.instagram.com/costanavarino/?hl=el");

            //στην συνεχεια καλουμε την μεθοδο ωστς να ανοιξει η ιστοσελιδα
            newpage.OpenWebPage();

        }

        private void twiterbutton_Click(object sender, EventArgs e)
        {
            //με το που πατησουμε το κουμπι  τοτε μας παει στην ιστσελιδα

            //φτιαχνουμε ενα αντικειμενο τυπου InternetPage οπου μεσα στον κονστρακτορα βαζουλε το λινκ που θα εχει

            InternetPage newpage = new InternetPage("https://twitter.com/costanavarino");

            //στην συνεχεια καλουμε την μεθοδο ωστς να ανοιξει η ιστοσελιδα
            newpage.OpenWebPage();

        }

        private void ytbbutton_Click(object sender, EventArgs e)
        {
            //με το που πατησουμε το κουμπι  τοτε μας παει στην ιστσελιδα

            //φτιαχνουμε ενα αντικειμενο τυπου InternetPage οπου μεσα στον κονστρακτορα βαζουλε το λινκ που θα εχει

            InternetPage newpage = new InternetPage("https://www.youtube.com/user/costanavarino");

            //στην συνεχεια καλουμε την μεθοδο ωστς να ανοιξει η ιστοσελιδα
            newpage.OpenWebPage();

        }

        private void fbbutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip1.Show("Βρείτε μας στο  Facebook", fbbutton);
        }

        private void instabutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip2.Show("Βρείτε μας στο Instagram", instabutton);
        }

        private void twiterbutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip3.Show("Βρείτε μας στο Twitter", twiterbutton);
        }

        private void pintbutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip4.Show("Βρείτε μας στο Pinterest", pintbutton);
        }

        private void ytbbutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip5.Show("Βρείτε μας στο Youtube", ytbbutton);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //φτιαχνουμε ενα αντικειμενο τυπου txt και καλουμε την μεθοδο ετσι ωστε να παρει τις πληροφοριες απο το 
            //richtextbox  και να τις γραψει σε ενα txt
            Txt contactfile = new Txt("contact.txt");
            contactfile.WriteTxt(richTextBox1);
            contactfile.SuccessWriteTxt();
              
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip6.Show("Αποθηκεύστε τις πληροφοριες στον υπολογιστη σας ", button1);
        }
    }
}
