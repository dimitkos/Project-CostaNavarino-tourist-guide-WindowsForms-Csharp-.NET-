using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace CostaNavarino
{
    public partial class FirstForm : Form1
    {
        
        //ftiaxnw ena neo dictionary opoy ua exw mesa dyo string ena gia to user kai ena gia to pass
        //to vazw edv gia na to blepoyn ola ta kommatia tou kwdika

        Dictionary<String, String> accounts = new Dictionary<string, string>();

        //fortwsame thn system media wste na ftiaksoume antikeimeno typou sounplayer
        //tha tha xrhsimopoihsoume etsi wste kata to login pera to mynhma na bgazei kai hxo wste na antilamvanetai o xrhsths kalytera 
        //an exie syndethei h oxi
        SoundPlayer success = new SoundPlayer();
        SoundPlayer fail = new SoundPlayer();
        
       

        public FirstForm()
        {
            InitializeComponent();

            //elitourgia kata tin enarksi tis forms to panel1 einai krymeno
            panel1.Hide();

            //φτιαχνς ena account me user:jim kai pass:123
            accounts.Add("jim", "123");
            //8a pros8eso ke ena deftero account
            accounts.Add("aris", "123");

            //μεσα στον φακελο του debug  εχουμε βαλει τα δυο αρχεια wav  για τον ηχο με τις αντιστοιχες ονομασιες
            success.SoundLocation = "success.wav";
            fail.SoundLocation = "fail.wav";

        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // kata to patima h leitoyrgia show emfanizei to panel1
            panel1.Show();
            //me to poy pathsw to koympi login to visit den mporei na patithei
            visitButton.Enabled = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void loginButtonPanel_Click(object sender, EventArgs e)
        {
            //vazoume mia metavliti password
            String password = "";
            //tha valoume enan elegxo opou tha vlepoume an yparxei to account sto dictionary pou ftiaksame
            //otan o xrhsths pataei to koumpi login
            //me apla logia o xrhsths dinei to username kai sthn synexeia to programma epistrefei to password 
            if (accounts.TryGetValue(userNameTextBox.Text, out password))
            {
                //elegxei an to pass pou edwse o xrhsths einai idio me to pass pou einia mesa sto dictionary
                if (password == PasswordTextBox.Text)
                {
                    try
                    {
                        //θα βγαλει τον ηχο επιτυχιας παιζοντας το αντιστοιχο αρχειο
                        success.Play();
                    }
                    catch(TimeoutException e1)
                    {
                        MessageBox.Show("Time out Exception");
                    }
                    catch(System.IO.FileNotFoundException e2)
                    {
                        MessageBox.Show("File Not Found");
                    }
                    catch(InvalidOperationException e3)
                    {
                        MessageBox.Show("Invalid Operation Exception");
                    }


                    //tha vgalei mhnyma epityxias tou login
                    MessageBox.Show("Login successfull");

                    UserForm userform = new UserForm();
                    //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
                    userform.Show(this);
                    //twra h prwth form kryvetai
                    this.Hide();

                }
                else
                {

                    try
                    {
                        //θα βγαλει τον ηχο αποτυχιας παιζοντας το αντιστοιχο αρχειο
                        fail.Play();
                    }
                    catch (TimeoutException e4)
                    {
                        MessageBox.Show("Time out Exception");
                    }
                    catch (System.IO.FileNotFoundException e5)
                    {
                        MessageBox.Show("File Not Found");
                    }
                    catch (InvalidOperationException e6)
                    {
                        MessageBox.Show("Invalid Operation Exception");
                    }

                    //παγωνουμε το threaad διοτι στο μουσικο αρχειο δεν ξεκιναιε η μουσικη απο το 0 δευετρολεπτο αργει λιγακι
                    //ενω ανοιγει αλλο thread  και εκτελουνται ταυτχορνα επειδη υπαρχει αυτη η καθυστερηση στον ηχο 
                    //παγωνουμε το βασικο thread  για  μισο δευτερολεπτο ωστε να δινει στον χρηστη την εντυοωση οτι γινονται ραυτοχορνα
                    System.Threading.Thread.Sleep(500);
                    MessageBox.Show("Wrong password");
                }

            }
            else
            {
                try
                {
                    //θα βγαλει τον ηχο αποτυχιας παιζοντας το αντιστοιχο αρχειο
                    fail.Play();
                }
                catch (TimeoutException e1)
                {
                    MessageBox.Show("Time out Exception");
                }
                catch (System.IO.FileNotFoundException e2)
                {
                    MessageBox.Show("File Not Found");
                }
                catch (InvalidOperationException e3)
                {
                    MessageBox.Show("Invalid Operation Exception");
                }
                //παγωνουμε το threaad διοτι στο μουσικο αρχειο δεν ξεκιναιε η μουσικη απο το 0 δευετρολεπτο αργει λιγακι
                //ενω ανοιγει αλλο thread  και εκτελουνται ταυτχορνα επειδη υπαρχει αυτη η καθυστερηση στον ηχο 
                //παγωνουμε το βασικο thread  για  μισο δευτερολεπτο ωστε να δινει στον χρηστη την εντυοωση οτι γινονται ραυτοχορνα
                System.Threading.Thread.Sleep(500);
                //Ean den iparxi to account sto dictionary mesa na kani print afto sto msqbox
                MessageBox.Show("Account does not exist");
            }

            //epishw me to pathma toy koumpiou katharizoyn to pass kai to user 
            PasswordTextBox.Clear();
            userNameTextBox.Clear();
            //kryvoume to panel1
            panel1.Hide();

        }

        private void loginButton_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Συνδεθείτε ως εγγεγραμένος χρήστης", loginButton);
        }

        private void visitButton_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Συνδεθείτε ως επισκέπτης", visitButton);
        }

        private void loginButtonPanel_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Συνδεθείτε με τα στοιχεία σας", loginButtonPanel);
        }

        private void visitButton_Click(object sender, EventArgs e)
        {
            VisitorForm visitorform = new VisitorForm();
            //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
            visitorform.Show(this);
            //twra h prwth form kryvetai
            this.Hide();
        }


        private void FirstForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //otan pame na klisoume thn efarmogh patwntas x,tha vgei ena mnm pou tha mas rwtaei ti theloume na kanoume
            //an pathsoume nai tote tha klisei alliws oxi tha meinei opws einai
            DialogResult dialogResult1 = MessageBox.Show("Are you sure ?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult1 == DialogResult.Yes)
            {
                e.Cancel = false;

            }
            else if (dialogResult1 == DialogResult.No)
            {

                e.Cancel = true;
            }
        }

        private void costanavarinoSiteLabel_Click(object sender, EventArgs e)
        {
            //με το που πατησουμε το label  τοτε μας παει στην ιστσελιδα

            //φτιαχνουμε ενα αντικειμενο τυπου InternetPage οπου μεσα στον κονστρακτορα βαζουλε το λινκ που θα εχει

            InternetPage newpage = new InternetPage("https://www.costanavarino.com/");

            //στην συνεχεια καλουμε την μεθοδο ωστς να ανοιξει η ιστοσελιδα
            newpage.OpenWebPage();
        }
    }
}
