using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostaNavarino
{
    public partial class VisitorForm : Form1
    {
        //δηλωνουμε μια λιστα οπουθα βαλουμε ολες τις ονομασιες txt  που θα δημιουργουν τα κουμπια μας που φτιαχνουν το ιστορικο
        ArrayList mytxtlist = new ArrayList();
        //φτιαχνουμε ενα αντικειμενο τυπου SoundPlayer
        SoundPlayer soundtrack = new SoundPlayer();
        public VisitorForm()
        {
            InitializeComponent();
            //και του λεμε που να βρει το αρχειο ηχου σε ποια τοποθεσια καθως και το ονομα και τον τυπου το αρχειου
            soundtrack.SoundLocation = "costanavarino.wav";
            mytxtlist.Add("desthistory.txt");
            mytxtlist.Add("maphistory.txt");
            mytxtlist.Add("calhistory.txt");
            mytxtlist.Add("golfhistory.txt");
            mytxtlist.Add("acthistory.txt");
        }

        private void VisitorForm_Load(object sender, EventArgs e)
        {
            try
            {
                //οταν φορτωθει η φορμα του λεμε να ξεκινησει να παιζιε σε επαναληψη συνεχως
                soundtrack.PlayLooping();
            }
            catch(TimeoutException e1)
            {
                MessageBox.Show("Time out Exception");
            }
            catch (System.IO.FileNotFoundException e2)
            {
                MessageBox.Show("File Not Found ");
            }
            catch (InvalidOperationException e3)
            {
                MessageBox.Show("Invalid Operation");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //me to poy pathsei o xrhsths to koumpi ayto ta grammata ginontai kokkino xrwma 
            //ayto to kanoume etsi wste na elegxoume to istoriko opws stis istoselides oti pathuhke enaw syndesmos px
            Destinationbutton.ForeColor = Color.Red;
            DestinationForm destinationform = new DestinationForm();
            //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
            destinationform.Show(this);
            //twra h prwth form kryvetai
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //me to poy pathsei o xrhsths to koumpi ayto ta grammata ginontai kokkino xrwma 
            //ayto to kanoume etsi wste na elegxoume to istoriko opws stis istoselides oti pathuhke enaw syndesmos px
            Mapbutton.ForeColor = Color.Red;
            MapForm mapform = new MapForm();
            //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
            mapform.Show(this);
            //twra h prwth form kryvetai
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //me to poy pathsei o xrhsths to koumpi ayto ta grammata ginontai kokkino xrwma 
            //ayto to kanoume etsi wste na elegxoume to istoriko opws stis istoselides oti pathuhke enaw syndesmos px
            Calendarbutton.ForeColor = Color.Red;
            CalendarForm calendarform = new CalendarForm();
            //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
            calendarform.Show(this);
            //twra h prwth form kryvetai
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //me to poy pathsei o xrhsths to koumpi ayto ta grammata ginontai kokkino xrwma 
            //ayto to kanoume etsi wste na elegxoume to istoriko opws stis istoselides oti pathuhke enaw syndesmos px
            Activitiesbutton.ForeColor = Color.Red;
            ActivitiesForm activitiesform = new ActivitiesForm();
            //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
            activitiesform.Show(this);
            //twra h prwth form kryvetai
            this.Hide();
        }

        private void VisitorForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            
            this.Hide();
            
            Owner.Show();
           
     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //to antikeimeno pou ftiaksame sthn klassh slideshowimages to vazoume na deixnei sto slideshowbox ths formas ayths
            SlideshowImages.picturebox1 = slideshowBox;
            //kai sthn synexeia kaloume thn methodo
            //epeidh einai static method thn kaloume me to onoma ths klasshs kaid en xreiazetai na ftiaksoume antikeimeno
            SlideshowImages.LoadNextImageSlide();
        }

        private void Destinationbutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip1.Show("Βρείτε περισσότερους προορισμούς", Destinationbutton);
        }

        private void Mapbutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip2.Show("Πληροφορίες για την τοποθεσία και την επικοινωνία", Mapbutton);
        }

        private void Calendarbutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip3.Show("Μάθετε για τις προσεχείς εκδηλώσεις", Calendarbutton);
        }

        private void Golfbutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip4.Show("Μάθετε περισσότερα για το γκολφ", Golfbutton);
        }

        private void Activitiesbutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip5.Show("Μάθετε για περισσόετερες δραστηριότητες", Activitiesbutton);
        }

        private void Golfbutton_Click(object sender, EventArgs e)
        {
            //me to poy pathsei o xrhsths to koumpi ayto ta grammata ginontai kokkino xrwma 
            //ayto to kanoume etsi wste na elegxoume to istoriko opws stis istoselides oti pathuhke enaw syndesmos px
            Golfbutton.ForeColor = Color.Red;

            GolfForm golfform = new GolfForm();
            //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
            golfform.Show(this);
            //twra h prwth form kryvetai
            this.Hide();
        }

        private void ResetHistorybutton_Click(object sender, EventArgs e)
        {

            //otan o xrhsths pathsei ekatharisei istorikoy tote epanaferontai ta koumpia opvw htan prin
            Destinationbutton.ForeColor = Color.Black;
            Mapbutton.ForeColor = Color.Black;
            Calendarbutton.ForeColor = Color.Black;
            Golfbutton.ForeColor = Color.Black;
            Activitiesbutton.ForeColor = Color.Black;

            //τωρα εδω θα σβησουμε το μονιμο ιστορικο αφου το επιθυμει ο χρηστης πατωντας αυτο το κουμπι
            //αρχικα κλινουμε τον  timer 2 ετσι ωστε να μην ανανεωνεται το αρχεια συνεχως
            timer2.Stop();
            //στην συνεχεια θα φτιαξουμε ενα αντικειμενο τυπου HistoryTrack
            HistoryTrack deletehist = new HistoryTrack();
            //και εδω καλουμε την μεθοδο ετσι ωστε να ελεγξει αν υπαρχουν τα αρχεια και να τα σβησει
            deletehist.DeleteHistory(mytxtlist);
        }

        private void ResetHistorybutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip6.Show("Διαγραφή του ιστορικού περιήγησης", ResetHistorybutton);
        }

        private void VisitorForm_Activated(object sender, EventArgs e)
        {
            
        }

        
        private void timer2_Tick(object sender, EventArgs e)
        {
            //αυτος  o timer ειναι ετσι ωστε να ανανεωνεται συνεχως η ο ελεγχος για ποια κουμπια ειναι πατημενα
            //φτιαχνω ενα αντικειμενο τυπου HistoryTrack ωστε να καλεσω της μεθοδους και να παρακολουθησω το ιστορικο του χρηστη
            HistoryTrack ht = new HistoryTrack();
            //καλω της μεθοδους ωστε για το καθε κουμπι να ελεγξω αν ειναι πατημενο καθως και να γραψει το καταλληλο μηνυμα στο αρχειο του
            ht.PrintHistory(Destinationbutton, "desthistory.txt");
            ht.PrintHistory(Mapbutton, "maphistory.txt");
            ht.PrintHistory(Calendarbutton, "calhistory.txt");
            ht.PrintHistory(Golfbutton, "golfhistory.txt");
            ht.PrintHistory(Activitiesbutton, "acthistory.txt");
            
        }
    }
}
