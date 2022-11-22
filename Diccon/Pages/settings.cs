using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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



        private void settings_Load(object sender, EventArgs e)
        {
            btDelete.BackColor = dicconProp.ColorA3;
        }

        private void btDeleteHistory_Click(object sender, EventArgs e)
        {


        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(dicconProp.historyFileName))
                {
                    if (MessageBox.Show(dicconProp.promptDeleteHistoryFile, dicconProp.caption, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        File.Delete(dicconProp.historyFileName);
                        //listHistory.DataSource = null;
                        //listHistory.Items.Clear();

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show(dicconProp.errorDeleteHistoryFile, dicconProp.caption);
            }
        }

        private void btDelete_MouseEnter(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_Darker_MouseEnter(sender, e);

        }

        private void btDelete_MouseLeave(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_Darker_MouseLeave(sender, e);
        }

        private void btAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (btAutoBackup.Checked == true) 
            { 
                Properties.Settings.Default["autoBackup"] = "True"; 
            }
            else
            {
                Properties.Settings.Default["autoBackup"] = "False";
            }
            Properties.Settings.Default.Save();
        }
    }
}
