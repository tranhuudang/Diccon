using Diccon.Pages;
using FontAwesome.Sharp;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace Diccon
{
    public partial class appFrame : Form
    {

        Form currentForm = null;
        Form dictionaryForm = null;
        Form aboutForm = null;
        Form donateForm = null;
        Form timelineForm = null;
        Form noteForm = null;
        
        public appFrame()
        {
            InitializeComponent();
        }

        private void AppFrame_Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default["staredForm"])
            {
                case "Dictionary":
                    dictionaryForm = new dictionary();
                    openForm(dictionaryForm);
                    break;
                case "Timeline":
                    timelineForm = new timeline();
                    openForm(timelineForm);
                    break;
                default:
                    // Stack up quotation
                    quote quote = new quote();
                    lbQuotation.Text = quote.getQuote("en");
                    break;
            }
           
        }

        /// <summary>
        /// Change Red and Green background of Rounded-Label to a darker shade of  color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoundedLabel_MouseEnter(object sender, EventArgs e)
        {
            RoundedLabel roundedLabel = (sender as RoundedLabel);
            int R = roundedLabel.BackColor.R >= 50 ? roundedLabel.BackColor.R - 50 : roundedLabel.BackColor.R;
            int G = roundedLabel.BackColor.G >= 50 ? roundedLabel.BackColor.G - 50 : roundedLabel.BackColor.G;
            int B = roundedLabel.BackColor.B;

            roundedLabel.BackColor = Color.FromArgb(R, G, B);
        }
        /// <summary>
        /// Change Red and Green background of Rounded-Label to a lighter shade of  color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoundedLabel_MouseLeave(object sender, EventArgs e)
        {
            RoundedLabel roundedLabel = (sender as RoundedLabel);
            int R = roundedLabel.BackColor.R <= 205 ? roundedLabel.BackColor.R + 50 : roundedLabel.BackColor.R;
            int G = roundedLabel.BackColor.G <= 205 ? roundedLabel.BackColor.G + 50 : roundedLabel.BackColor.G;
            int B = roundedLabel.BackColor.B;

            roundedLabel.BackColor = Color.FromArgb(R, G, B);
        }
        /// <summary>
        /// Change position of PictureBox to create a illusion that the box is lift up a little bit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (sender as PictureBox);
            int X = pictureBox.Location.X;
            int Y = pictureBox.Location.Y - 2;
            pictureBox.Location = new Point(X, Y);
        }
        /// <summary>
        /// Change position of PictureBox to create a illusion that the box is push down a little bit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (sender as PictureBox);
            int X = pictureBox.Location.X;
            int Y = pictureBox.Location.Y + 2;
            pictureBox.Location = new Point(X, Y);
        }

        private void btDictionary_Click(object sender, EventArgs e)
        {
            if (dictionaryForm != null)
            {

                openForm(dictionaryForm);
            }
            else
            {
                dictionaryForm = new dictionary();
                openForm(dictionaryForm);
            }
        }
        private void openForm(Form targetForm)
        {
            btStar.Visible = false;
            string formName = targetForm.Text;
            title.Text = formName;
            string[] pagesName = { "Dictionary", "Yawa", "Notes", "Timeline" };
            logo.Image = Properties.Resources.back_24;
            ///Star button
            foreach (string item in pagesName)
            {
                if(formName==item)
                {
                    if (Properties.Settings.Default["staredForm"].ToString() == targetForm.Text)
                    {
                        btStar.IconColor = Color.Gold;
                        btStar.IconFont = IconFont.Solid;
                    }
                    else
                    {
                        btStar.IconColor = Color.Black;
                        btStar.IconFont = IconFont.Regular;
                    }
                    btStar.Visible = true;
                    break;
                }
            }
            ///
            if (currentForm != null)
            {
                currentForm.Hide();
                panelHome.Visible = false;
                currentForm = targetForm;
                currentForm.TopLevel = false;
                currentForm.FormBorderStyle = FormBorderStyle.None;
                currentForm.Dock = DockStyle.Fill;
                playGroundPanel.Controls.Add(currentForm);
                currentForm.Show();
            }
            else
            {
                panelHome.Visible = false;
                currentForm = targetForm;
                currentForm.TopLevel = false;
                currentForm.FormBorderStyle = FormBorderStyle.None;
                currentForm.Dock = DockStyle.Fill;
                playGroundPanel.Controls.Add(currentForm);
                currentForm.Show();
            }

        }

        private void logo_Click(object sender, EventArgs e)
        {
            btStar.Visible = false;
            title.Text = "Diccon";
            logo.Image = Properties.Resources.ninja_64;
            if (currentForm != null)
            {
                currentForm.Hide();
                panelHome.Visible = true;
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            int X = Cursor.Position.X - 155;
            int Y = Cursor.Position.Y + 15;
            contextMenu.Show(X, Y);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutForm != null)
            {

                openForm(aboutForm);
            }
            else
            {
                aboutForm = new about();
                openForm(aboutForm);
            }

        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
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
                        Thread thread = new Thread(() =>
                        {

                            WebClient webClient = new WebClient();
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


        private void WebClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (MessageBox.Show(dicconProp.downloadSetupCompleteMessage, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start(dicconProp.setupName);
                Application.Exit();
            }
        }

        private void playGroundPanel_ControlAdded(object sender, ControlEventArgs e)
        {
          
        }

        private void btStar_Click(object sender, EventArgs e)
        {
            string staredForm = Properties.Settings.Default["staredForm"].ToString();
            if (staredForm=="default")
            {
                btStar.IconColor = Color.Gold;
                btStar.IconFont =IconFont.Solid;
                Properties.Settings.Default["staredForm"] = title.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                btStar.IconColor = Color.Black;
                btStar.IconFont = IconFont.Regular;
                Properties.Settings.Default["staredForm"] = "default";
                Properties.Settings.Default.Save();

            }

        }

        private void appFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void btDonate_Click(object sender, EventArgs e)
        {
            

            if (donateForm != null)
            {

                openForm(donateForm);
            }
            else
            {
                donateForm = new donate();
                openForm(donateForm);
            }
        }

        private void btTimeline_Click(object sender, EventArgs e)
        {
            if (timelineForm != null)
            {

                openForm(timelineForm);
            }
            else
            {
                timelineForm = new timeline();
                openForm(timelineForm);
            }
        }

        private void buttonYourNote_Click(object sender, EventArgs e)
        {

            if (noteForm != null)
            {

                openForm(noteForm);
            }
            else
            {
                noteForm = new notes();
                openForm(noteForm);
            }
        }

        private void roundedLabel7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This function is coming soon.");
        }
    }
}
