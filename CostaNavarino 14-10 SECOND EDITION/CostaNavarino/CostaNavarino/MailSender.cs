using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostaNavarino
{
    public class MailSender
    {
        private MailMessage msg;

        public void Sendmail(TextBox textBox1, TextBox textBox2)
        {
            //για τις αναγκες της παρουσας εργασιας φτιαξαμε ενα mail projectsunipi@gmail.com.
            //για λογους ασφαλειας επιλεξαμε μην βαζει ακποιος το κανονικο μεηλ του και τους κωδικους του
            //ετσι λοιπον οτι μεηλ και να γραψει στο textbox θα φυγει και θα παραληφθει απο το παραπανω μεηλ

            try
            {
                //φτιαχνω ενα αντικειμενο τυπου MailMessage οπου σαν ορισματα θα εχει το μεηλ αυτουνου που στελνει,που θα παει,το θεμα του μεηλ καθως και το κειμενο
                msg = new MailMessage(textBox1.Text, "projectsunipi@gmail.com", "Costa Navarino ", textBox2.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.GetType().Name);
            }
            catch (ArgumentException ex1)
            {
                MessageBox.Show(ex1.GetType().Name);
            }



            //φτιαχνουμε ενα αντικειμενο τυπου SmtpClient οπου μας βοηθαει να στελνουμε μεηλ με το smtp 
            SmtpClient mail = new SmtpClient();
            //κθοριζουμε το ονομα του host
            mail.Host = "smtp.gmail.com";
            //kauorizoym me poia porta ua ginei h epikoinvnia
            mail.Port = 587;
            //για να γινει το authedication  βαζουμε τα credentials
            mail.Credentials = new NetworkCredential("projectsunipi@gmail.com", "projectcsharp");
            //για να κρυπτογραφησει την επικοινωνια κανουμε ενεργοποιηση του  ssl
            mail.EnableSsl = true;
            //στελνει το μηνυμα στον  smtp server 
            try
            {
                mail.Send(msg);
                MessageBox.Show("Message has been sent");
            }
            catch (SmtpException exc)
            {
                MessageBox.Show(exc.GetType().Name);
            }
            catch (ArgumentException e1)
            {
                MessageBox.Show("Argument Exception");
            }
            catch (InvalidOperationException e2)
            {
                MessageBox.Show("Invalid Operation Exception");
            }
        }
    }
}
