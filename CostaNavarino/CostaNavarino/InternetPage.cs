using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostaNavarino
{
    public class InternetPage
    {
        private String urlname;

        //ο κοντρακτορας τησ κλασης οπου αρχικοποιουμε το url της σελιδας που θελουμε αν ανοιξουμε
        public InternetPage(String urlname)
        {
            this.urlname = urlname;
        }


        //μεθοδος στην οποια οταν καλεστει ανοιγει την σελιδα που θελουμε
        public void OpenWebPage()
        {
            try
            {
                Process.Start(urlname);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                MessageBox.Show("Win32 Exception");
            }
            catch (ObjectDisposedException e1)
            {
                MessageBox.Show("Object Disposed Exception");
            }
            catch (System.IO.FileNotFoundException e2)
            {
                MessageBox.Show("File Not Found");
            }
        }
    }
}
