using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostaNavarino
{
    public class Txt
    {

        private String namefile;
        //ειναι μια κλαση η οποιοα μας βοηθαει να αποθηκευει ο χρηστης πληροφοριες απο την εφαρμογη

        public Txt(String namefile)
        {
            this.namefile = namefile;
        }
        


         //η μεθοδος περνει δυο ορισματα,ενα το ονομα του αρχειου που θα γραψει ,και η αλλη το ααντικειμενο τυπου richtextbox
         //αποπου θα παρει τις πληροφοριες και αθ τις γραψει
        public  void WriteTxt(RichTextBox richtbox)
        {
            try
            {
                //το κειμενο που εχει το richTextBox1 το αναθετουμε στην μεταβλητη

                string t = richtbox.Text;
                //στην συνεχεια θα δημιουργησουμε ενα αρχειο με το ονομα golf.txt οπου θα το γραψουμε ,αν θα υπηρχε θα το εκανε overwrite
                //pernei false giati den theloume append alla overwrite
                using (StreamWriter sw1 = new StreamWriter(namefile, false))
                {
                    try
                    {
                        sw1.Write(t);
                    }
                    catch (ObjectDisposedException e1)
                    {
                        MessageBox.Show("Object Disposed Exception");
                    }
                    catch (NotSupportedException e2)
                    {
                        MessageBox.Show("Not Supported Exception");
                    }
                    catch (IOException e3)
                    {
                        MessageBox.Show(e3.GetType().Name);
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

        public void SuccessWriteTxt()
        {
            if (File.Exists(namefile))
            {
                MessageBox.Show("To κείμενο αποθηκεύτηκε στον υπολογιστή σας");
            }
            else
            {
                MessageBox.Show("Προσπαθήστε ξανά");
            }
        }
    }
}
