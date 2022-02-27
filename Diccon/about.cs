using System;
using System.Diagnostics;
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
            Process.Start("https://github.com/zeroclubvn/Diccon");
        }

        private void about_Load(object sender, EventArgs e)
        {
            lbVersion.Text = Application.ProductVersion.ToString();
        }
    }
}
