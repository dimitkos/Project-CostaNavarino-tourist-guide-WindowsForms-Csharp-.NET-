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
    public partial class CalendarForm : Form1
    {
        public CalendarForm()
        {
            InitializeComponent();
            //αρχικα το πανελ1 οπου εχει να δεις τα σχολεια ειναι κρυμμενο
            panel1.Hide();
            //η τιμη που θα εχει το dateTimePicker1.Value ειναι η σημερινη ημερομηνια
            dateTimePicker1.Value = DateTime.Today;
            //το textbox το οποιο εμφανιζιε τα σχολια το κανουμε να ειναι μονο για διαβασμα
            // και ετσι ωστε ο χρηστης να μην μπορει να σβησει τα σχολια
            textBox3.ReadOnly = true;
        }

        private void CalendarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ayth h forma kryvetai kai sthn synexeia leei sthn forma poy thn dhmiourghse na emfanistei
            this.Hide();
            Owner.Show();
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            //φτιαχνουμε ένα αντικειμενο τυπου datetime  οπου του οριζουμε την παρακατω ημερομηνια
            DateTime dt = new DateTime(2018, 10, 19);

            //στην συνεχεια καλουμε την μεθοδο απο την κλασση που έχουμε φτιάξει για να ελεγξει την ημερομηνια και
            //να τυπωσει το αντιστοιχο μηνυμα στο label
            //ayto to kanoyme sthn formload διοτι μολις γινει load  η φορμα και παρει την σημερινη ημερομηνια
            //θα πρεπει να βγαλει ενα μηνυμα στο label  αλλιως το label  εν θα ειχε τιμη.
            DateEvent.PrintEvent(dateTimePicker1.Value, dt, label1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2018, 10, 19);
            
            //τωρα την καλουμε την μεθοδο και εδω διοτι με αυτο τον τροπο οταν ο χρηστης αλλαξει την ημερομηνια 
            //θα πρεπει να του βγαζει το καταλληλο μηνυμα
            DateEvent.PrintEvent(dateTimePicker1.Value, dt, label1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //με το πατημα του κουμπιου εμφανιζεται το panel1  οπου περιεχει το textbox3 οπου θα  εμφανισιε το περιεχομενο 
            //του txt αρχειου οπου καταχωρουνται τα σχολια
            panel1.Show();
            try
            {
                StringBuilder sb = new StringBuilder();
                using (StreamReader sr = new StreamReader("comments.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        sb.AppendLine(sr.ReadLine());
                    }
                    textBox3.Text = sb.ToString();
                }
            }
            catch(IOException e3)
            {
                MessageBox.Show(e3.GetType().Name);
            }
            catch (ArgumentException e4)
            {
                MessageBox.Show(e4.GetType().Name);
            }
            //τα υπολοιπα exceptions ειναι υποκατηγοριες των παραπανω

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //φτιαχνουμε ένα αντικειμενο τυπου datetime  του οποιου του δινουμε να εχει την σημερινη ωρα και ημερομηνια 
            //και την αποθηκευουμε σε μια μεταβλητη τυπου  string 
            DateTime date = DateTime.Now;
            string formattedDate = date.ToString("dddd, dd MMMM yyyy HH:mm");
            //στην συνεχεια θα κανουμε append  σε ενα αρχειο . αν αυτο το αρχειο δεν υπαρχιε θα το δημιουργησει
            try
            {
                using (StreamWriter sw1 = File.AppendText("comments.txt"))
                {
                    //ελεγχει αν το ονομα του χρηστη ειναι κενο,και του δινει το text  ανωνυμος
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "Anonymous";
                    }
                    //στην περιπτωση ομως που το text  του σχολειου ειναι κενο του λεει οτι πρεπει να γραψει μηνυμα
                    //αν ολα ειναι οκ τοτε φραφει το μηνυμα
                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("you must type a comment");
                    }
                    else
                    {
                        //στην συνεχεια του λεμε να γράψει τα καταλληλα μηνυμα,σε περιπτωση που παραχθει καποιο
                        //exception  βγαινουν τα αντιστοιχα μηνυματα
                        try
                        {
                            sw1.WriteLine("---------------------------------------------------------------");
                            sw1.WriteLine("Ο χρήστης " + textBox1.Text + " την ημερομηνία " + formattedDate + " σχολίασε: ");
                            sw1.WriteLine(textBox2.Text);
                        }
                        catch (IOException e1)
                        {
                            MessageBox.Show(e1.GetType().Name);
                        }
                        catch (ObjectDisposedException e2)
                        {
                            MessageBox.Show("Object Disposed Exception");
                        }
                    }

                }
            }
            catch(ArgumentException e1)
            {
                MessageBox.Show("Argument Exception");
            }
            catch (UnauthorizedAccessException e2)
            {
                MessageBox.Show("Unauthorized Access Exception");
            }
            catch (PathTooLongException e3)
            {
                MessageBox.Show("Path Too Long Exception");
            }
            catch (DirectoryNotFoundException e4)
            {
                MessageBox.Show("Directory Not Found");
            }
            catch (NotSupportedException e5)
            {
                MessageBox.Show("Not Supported Exception");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //κρυβεται το πανελ οπου εχει τα σχολια
            panel1.Hide();
        }

        private void submitbutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip1.Show("Κάνε υποβολή το σχόλιο σας", submitbutton);
        }

        private void viewbutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip2.Show("Δείτε όλα τα σχόλια των χρηστών", viewbutton);
        }

        private void closecommbutton_MouseHover(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip3.Show("Κλείστε τα σχόλια", closecommbutton);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
