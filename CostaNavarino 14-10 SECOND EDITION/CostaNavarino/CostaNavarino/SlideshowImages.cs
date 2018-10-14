using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostaNavarino
{
    public class SlideshowImages
    {
        private static int imagenumber = 1;
        public static PictureBox picturebox1 = new PictureBox();

        //kaname static thn methodo wste na mhn xreiastei na dhmiourghsoume antikeimeno 
        //thn methodo aythn tha thn kalesoume mesa ston timer ths visitform
        public static void LoadNextImageSlide()
        {
            //exoume 6 eikonew sto fakelo ,otan ftasei sthn telikh eikona tote 
            //toy leei o arithmos na ksanaginei monada kai ousiastika na paei ksana sthn eikona 1
            if (imagenumber == 5)
            {
                imagenumber = 1;
            }
            //sthn synexeia sto antikeimeno pou dhmiourghsame paei kai vriskei ston fakelo debug ton fakelo me tis eikonew
            picturebox1.ImageLocation = string.Format(@"Images\{0}.jpg", imagenumber);
            //aykanetai o metrhths kata 1 
            imagenumber++;
        }
    }
}
