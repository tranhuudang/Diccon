using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccon
{
    public class AutoSizeRichTextBox : System.Windows.Forms.RichTextBox
    {

        int lineHeight = 12;
        protected override void OnResize(EventArgs e)
        {
           
        }

    }

}
