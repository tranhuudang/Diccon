using Diccon.Pages;
using System;
using System.Windows.Forms;

namespace Diccon
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void gitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void about_Load(object sender, EventArgs e)
        {
            btRelease.BackColor = DicconProp.ColorA3;
            topPanel.BackColor = DicconProp.AccentColor;

            lbVersion.Text = Application.ProductVersion.ToString();
        }


        private void btUpdate_Click(object sender, EventArgs e)
        {

        }


        private void WebClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

        }


        private void btUpdates_MouseEnter(object sender, EventArgs e)
        {
            DicconProp.RoundedLabel_MouseEnter(sender, e);
        }

        private void btUpdates_MouseLeave(object sender, EventArgs e)
        {
            DicconProp.RoundedLabel_MouseLeave(sender, e);
        }

        private void lbGithub_Click(object sender, EventArgs e)
        {

        }

        private void btRelease_Click(object sender, EventArgs e)
        {
            release release = new release();
            release.Show();
            
        }

        private void btRelease_MouseEnter(object sender, EventArgs e)
        {
            DicconProp.RoundedLabel_Darker_MouseEnter(sender, e);

        }

        private void btRelease_MouseLeave(object sender, EventArgs e)
        {
            DicconProp.RoundedLabel_Darker_MouseLeave(sender, e);

        }

        private void logo_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
