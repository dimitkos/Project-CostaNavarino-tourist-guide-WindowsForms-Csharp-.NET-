using System;
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
    public partial class UserForm : Form1
    {
        //μεταβλητη οπου την χρησιμοποιουμαι πιο κατω, χρησιμευει ετσι ωστε αναλογα το radiobutton που επιλεγει ο χρηστης
        //αντιπροσωπευει τα λεφτα που κοστιζει για ενα βραδυ το δικλινο,τρικλινο,σουιτα
        int money;
        public UserForm()
        {
            InitializeComponent();
            //αρχικα βάζουμε το radiobutton να ειναι τυχαια επιλεγμενο, ο χρηστης φυσικα μπορει να το αλλαξει
            radioButton1.Checked = true;
            //το πανελ οπου περιεχει την εμφανιση της κρατησης καθως και το κλεισιμο αυτης αρχικα θα ειναι κρυμμενο
            panel1.Hide();
            //αρχικοποιουμαι τους δυο datetimepicker,o ενας θα εχει την ημερομηνια της τρεχοντας μερας
            dateTimePicker1.Value = DateTime.Today;
            //ο αλλος θα εχει της επομενης μερας.αυτο γινεται διοτι εχουμε κρατηση οποτε ο χρηστης δεν μπορει να συμπεσει αφιξη και αναχωρηση ιδια μερα
            dateTimePicker2.Value = DateTime.Today.AddDays(+1);
            //αρχικοποιω της ελαχιστες ημερομηνιες που μπορει να εχει ο καθε datetimepicker 
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today.AddDays(+1);
            //αρχικοποιουμε οτι το  textbox2 θα ειναι μονο για αναγνωση και ο χρηστης δεν μπορει να παρεμβει σβηνωντας η γραφωντας
            textBox2.ReadOnly = true;
            //αρχικα το κουμπι "δειτε την κρατηση " ειναι απενεργοποιημενο
            viewbutton.Enabled = false;
        }


        private void UserForm_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {


            VisitorForm visitorform = new VisitorForm();
            //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
            
            visitorform.Show(this);
           
            //twra h prwth form kryvetai
            this.Hide();
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
            Owner.Show();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //αν δεν υπαρχει το αρχειο το δημιουργουμε,αλλιως αν υπαρχει το κανουμε overwrite
            //περνει false το δευτερο ορισμα giati den ueloyme na ginei  append αλλα overwrite
            //το πρωτο ορισμα ειναι το ονομα του αρχειου
            try
            {

                using (StreamWriter sw1 = new StreamWriter("register.txt", false))
                {
                    //αν ο χρηστης εχει αφησει το ονοματεπωνυμο κενο τοτε βγαζει προειδοποιητικο μηνυμα
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Παρακαλώ συμπληρώστε το ονοματεπώνυμο σας");

                    }
                    else
                    {
                        //εφοσον ο χρηστης εχει συμπληρωσει το ονοματεπωνυμο του θα κανουμε εναν δευτερο ελεγχο
                        //θα πρεπει η ημερομηνια αφιξης του datetimepicker1  να ειναι μικροτερη της ημερομηνιας του datetimepicker2

                        if ((dateTimePicker1.Value < dateTimePicker2.Value))
                        {

                            //στην συνεχεια υπολογιζουμε την διαφορα των ημερων ωστε να βρουμε ο χρηστης ποσες μερες θα μεινει
                            TimeSpan tmsp = dateTimePicker2.Value - dateTimePicker1.Value;
                            //η μεθοδος αυτη μας επιστρεφει εναν αριθμο οπου ειναι double
                            double diffdays = tmsp.TotalDays;
                            //και στην συνεχεια τον μετατρεπουμε σε ακεραιο
                            int days = Convert.ToInt32(diffdays);

                            //ελεγχουμε πιο radiobutton  εχει επιλεξει ο χρηστης και αναλογα με την επιλογη αντιστοιχει σε ενα δωματιο
                            //οπου το δωματιο αυτο εχει μια συγκεκριμενη τιμη 
                            if (radioButton1.Checked == true)
                            {
                                money = 200;
                            }
                            if (radioButton2.Checked == true)
                            {
                                money = 300;
                            }
                            if (radioButton3.Checked == true)
                            {
                                money = 500;
                            }
                            //στην συνεχεια γραφουμε σε αυτο το αρχειο τα στοιχει,ονομα αφιξη,αναχωρηση,ποσες μερες θα μεινει,και το συνολικο ποσο που θα πληρωσει
                            sw1.WriteLine("Ονομα: " + textBox1.Text);
                            sw1.WriteLine("Ημέρα άφιξης: " + dateTimePicker1.Value.ToString());
                            sw1.WriteLine("Ημέρα αναχώρισης: " + dateTimePicker2.Value.ToString());
                            sw1.WriteLine("Διανυκτερεύσεις: " + days);
                            sw1.WriteLine("Συνολικό ποσό: " + days * money + " Eυρώ");
                            //εφοσον περασει τους απαραιτητους ελεγχους και πλεον μπορει να γινει η κρατηση το κουμπι μπορει αν το πατησει ο χρηστης
                            viewbutton.Enabled = true;
                        }
                        else
                        {
                            //αν δωσει λαθος ημερομηνιες,δηλαδη ημερα αναχωρησης ειναι νωριτερα απο την μερα αφιξης τοτε του βγαζει μηνυμα λαθους
                            MessageBox.Show("Λάθος ημερομηνίες,παρακαλώ ελέγξτε ξανά ");
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                //τον παραπανω κωδικα τον βαλαμε μεσα σε try  ετσι ωστε αν συμβει κατι μη αμαμενομενο
                // τοτε θα το χειριστουμε εμεις μεσω του catch  και δεν θα κρεμασει το προγραμμα μας  
                MessageBox.Show(ex.GetType().Name);
            }
            catch (UnauthorizedAccessException e1)
            {
                MessageBox.Show("Unauthorized Access Exception");
            }
            catch (ArgumentException e2)
            {
                MessageBox.Show("Argument Exception");
            }

            //ta ypoloipa exception einai ypokathgories tou ioexception kai argument exception
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //εμφανιζεται το πανελ οπου θα τυπωνεται η κρατηση του πελατη
            panel1.Show();

            //δημιουργουμε ενα αντικειμενο τυπου stringbuilder ,επειδη τα  strings  ειναι αμεταλλακτα και δημιουργουμε νε ααντικειμενα αντιγραφα τους
            //γι αυτο τον λογο για να μην δημιουργησουμε ενα αντικειμενα επειδη εχουμε επαναλμβανομενες τροποποιησεις string χρησιμοποιουμε την stringbuilder
            StringBuilder sb = new StringBuilder();
            try
            {
                //μεσω της  streamreader  θα διαβασουμε ενα txt 
                using (StreamReader sr = new StreamReader("register.txt"))
                {
                    //η μεθοδος peek()  επιστρεφει εναν ακεραιο που μας λεει αν εχει ληξει το αρχειο η προεκυψε καποιο σφαλμα
                    //ετσι ελεγχουμε αν μας δωσει τιμη -1.
                    while (sr.Peek() >= 0)
                    {
                        //κανει append data στον  string builder αυτα που διαβαζει εμσω του txt απο τον streamreader
                        sb.AppendLine(sr.ReadLine());
                    }
                    //στην συνεχεια τα εμφανιζει στο textbox2.
                    textBox2.Text = sb.ToString();
                }
            }
            catch (IOException ex)
            {
                //τον παραπανω κωδικα τον βαλαμε μεσα σε try  ετσι ωστε αν συμβει κατι μη αμαμενομενο
                // τοτε θα το χειριστουμε εμεις μεσω του catch  και δεν θα κρεμασει το προγραμμα μας  
                MessageBox.Show(ex.GetType().Name);
            }
            catch (ArgumentException e3)
            {
                MessageBox.Show("Argument Exception");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //πατωντας το κουμπι οκ ο χρηστης κλινει το παραθυρο οπου βλεπει την κρατηση του
            panel1.Hide();
        }

        private void submitbutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip1.Show("Υποβολή της κράτησης σας", submitbutton);
        }

        private void viewbutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip2.Show("Δείτε την κράτηση σας", viewbutton);
        }

        private void okbutton_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Κλείστε το παράθυρο", okbutton);
        }

        private void nextbutton_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Μεταβείτε στο κεντρικό μενού", nextbutton);
        }
    }
}
