using System;
using System.Diagnostics;
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
            Process.Start("https://github.com/zeroclubvn/Diccon");
        }

        private void about_Load(object sender, EventArgs e)
        {
            lbVersion.Text = Application.ProductVersion.ToString();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument updateFile = new XmlDocument();
                updateFile.Load(dicconProp.updateInfo + "?" + DateTime.Now.Ticks.ToString());
                Version netVersion = new Version(updateFile.SelectSingleNode("//currentVersion/version").InnerText);
                string describe = updateFile.SelectSingleNode("//currentVersion/describe").InnerText;
                string linkSetup = updateFile.SelectSingleNode("//path").InnerText;
                Version currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
                if (netVersion > currentVersion)
                {
                    if (MessageBox.Show(dicconProp.updateAvailableMessage, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        panelUpdate.Visible = true;
                        Thread thread = new Thread(() =>
                        {

                            WebClient webClient = new WebClient();
                            webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
                            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
                            webClient.DownloadFileAsync(new Uri(linkSetup), dicconProp.setupName);
                        });
                        thread.Start();
                    }

                }
                else
                {
                    MessageBox.Show(dicconProp.noUpdateAvailableMessage, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't connect to the internet!");
            }
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                downloadPercent.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }

        private void WebClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
                Process.Start(dicconProp.setupName);
                Application.Exit();
        }
    }
}
