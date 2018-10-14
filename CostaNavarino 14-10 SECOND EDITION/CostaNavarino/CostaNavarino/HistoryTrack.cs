using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostaNavarino
{
    public class HistoryTrack :IHistory
    {
        //μια μεθοδος η οποια περνει σαν ορισμα ενα τυπου button  και ενα  string 
        public void PrintHistory(Button btn, String text)
        {
            //ελεγχει το χρωμα του κουμπιου,στην δικια μας περιπτωση εχουμε βαλει οταν πατα ο χρηστης να γινεται κοκκινο
            //οποτε ελεγχει αν τα γραμματα του κουμπιου ειναι κοκκινα και σητν συνεχεια τυπωνει το μηνυμα οτι ο χρηστης ειδε αυτη την καρτελα
            //με το δευτερο ορισμα το περναμε ωστε να παρει το αρχειο  txt  ενα ονομα

            if (btn.ForeColor == Color.Red)
            {
                try
                {
                    using (StreamWriter sw1 = new StreamWriter(text, false))
                    {
                        try
                        {
                            sw1.Write("Ο χρήστης είδε την καρτέλα " + btn.Text);
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
                catch (SecurityException e3)
                {
                    MessageBox.Show("Security Exception");
                }

                //ta ypoloipa exception einai ypokathgories tou ioexception kai argument exception
            }
            else
            {
                try
                {

                    //αν το κουμπι δνε εχιε πατηθει τοτε γραφουμε το αντιχτοιχο μηνυμα
                    using (StreamWriter sw1 = new StreamWriter(text, false))
                    {
                        try
                        {
                            sw1.Write("Ο χρήστης δεν είδε την καρτέλα " + btn.Text);
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
                catch (SecurityException e3)
                {
                    MessageBox.Show("Security Exception");
                }
            }
        }

        //ειναι μια μεθοδος η οποια περνει μια λιστα που στην περιπτωση μας θα εχει string τα ονοματα των αρχειων
        //και καθε στοιχειο της λιστας θα το ελεγχει αν υπαρχει,δηλαδη αν υπαρχει το αρχειο txt ,αν υπαρχει θα το σβηνει
        //αυτο γινεται γιατι ο χρηστης οταν παταει εκκαθαριση ιστορικου θελουμε να διαγραφει αυτα τα αρχεια
        public  void DeleteHistory(ArrayList arr)
        {
            foreach (String t in arr)
            {
                if (File.Exists(t))
                {
                    try
                    {
                        File.Delete(t);
                    }
                    catch(ArgumentException e1)
                    {
                        MessageBox.Show("Argument Exception");
                    }
                    catch (IOException e2)
                    {
                        MessageBox.Show(e2.GetType().Name);
                    }
                    catch (NotSupportedException e3)
                    {
                        MessageBox.Show("Not Supported Exception");
                    }
                    catch (UnauthorizedAccessException e4)
                    {
                        MessageBox.Show("Unauthorized Access Exception");
                    }


                }
            }
        }
    }
}
