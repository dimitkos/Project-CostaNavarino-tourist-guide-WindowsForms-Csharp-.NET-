using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostaNavarino
{
    public class DateEvent
    {
        //ειναι μια στατικη μεθοδος,δηλαδη δεν χρειαζεται να φτιαξω αντικειμενο αλλα την καλω μ ετο ονομα τησ κλασσησ
        //σε αυτη την μεθοδο περνει τρεις παραμετρους,δυο τυπου datetime και μια τυπου label 
        //συγκρινει τα δυο αντικειμενα τυπου datetime  και στην συνεχεια βγαζει το καταλληλο μηνυμα σε ενα label
        public static void PrintEvent(DateTime dt, DateTime dateuse, Label anewlabel)
        {

            if (dt.Equals(dateuse))
            {
                anewlabel.Text = "Συνέδριο Πληροφορικής";

            }
            else
            {
                anewlabel.Text = "Δεν υπάρχει σήμερα κάποια εκδήλωση!";
            }

        }

    }
}
