using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostaNavarino
{
    interface IHistory
    {
        void PrintHistory(Button btn, String text);
        void DeleteHistory(ArrayList arr);
    }
}
