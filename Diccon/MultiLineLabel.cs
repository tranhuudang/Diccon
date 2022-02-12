using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccon
{
    public class MultiLineLabel : System.Windows.Forms.Label
    {
       
            bool mline = true;

        public bool Mline { get => mline; set => mline = value; }

        protected override void OnResize(EventArgs e)
            {
                int tw = 0;
                int i = 0;
                String s = base.Text;
                String c = String.Empty;
                Font f = base.Font;
                Control parent = base.Parent;
                //get the width of label
                int lw = base.Width;
                //get the with of parent control
                int cw = 290;// coloredPanelExampleWidth
                StringBuilder sb = null;
                if (Mline == true)
                {
                    if (lw > cw)
                    {
                        while (tw < cw)
                        {
                            i += 1;
                            c = s.Substring(0, i);
                            //calculate the length of string
                            Size txtSize = TextRenderer.MeasureText(c, f);
                            //get the width of text 
                            tw = txtSize.Width;
                        }
                        //decrease the length of text 
                        i -= 1;
                        //insert brakes
                        sb = new StringBuilder();
                        int j = 0;
                        while (j < s.Length)
                        {
                            if (j + i > s.Length) i = s.Length - j;
                            c = s.Substring(j, i); //+ "/r/n";
                            sb.AppendLine(c);
                            j += i;
                        }
                        base.Text = sb.ToString();
                    }
                }
                base.OnResize(e);
            }

        }
    
}
