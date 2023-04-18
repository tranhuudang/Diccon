using System;
using System.IO;
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
            btDelete.BackColor = DicconProp.ColorA3;
        }

        private void btDeleteHistory_Click(object sender, EventArgs e)
        {


        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(DicconProp.HistoryFileName))
                {
                    if (MessageBox.Show(DicconProp.PromptDeleteHistoryFile, DicconProp.Caption, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        File.Delete(DicconProp.HistoryFileName);
                        //listHistory.DataSource = null;
                        //listHistory.Items.Clear();

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show(DicconProp.ErrorDeleteHistoryFile, DicconProp.Caption);
            }
        }

        private void btDelete_MouseEnter(object sender, EventArgs e)
        {
            DicconProp.RoundedLabel_Darker_MouseEnter(sender, e);

        }

        private void btDelete_MouseLeave(object sender, EventArgs e)
        {
            DicconProp.RoundedLabel_Darker_MouseLeave(sender, e);
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
