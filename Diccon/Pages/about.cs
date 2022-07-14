using System;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

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
            dicconProp.RoundedLabel_MouseEnter(sender,e);
        }

        private void btUpdates_MouseLeave(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_MouseLeave(sender, e);
        }
    }
}
