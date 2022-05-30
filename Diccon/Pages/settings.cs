using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccon
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void enableFlashClipboard_CheckedChanged(object sender, EventArgs e)
        {
           if(enableFlashClipboard.Checked==true)
            {
                Properties.Settings.Default["FlashClipboard"] = "True";
                dicconProp.enableFlashClipboard = "True";

            }
            else
            {
                Properties.Settings.Default["FlashClipboard"] = "False";
                dicconProp.enableFlashClipboard = "False";
                
            }
            Properties.Settings.Default.Save();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default["FlashClipboard"].ToString() == "True")
            {
                enableFlashClipboard.Checked = true;
            }
            else
            {
                enableFlashClipboard.Checked = false;
            }
        }
    }
}
