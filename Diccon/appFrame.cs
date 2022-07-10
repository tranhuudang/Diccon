using Diccon.Pages;
using FontAwesome.Sharp;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using QuoteBank;
using System.Xml;
using WK.Libraries.WTL;
using static WK.Libraries.WTL.ThemeListener;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;

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
        Form settingForm = null;
        Form yawaForm = null;
        Form loginForm = null;
        public appFrame()
        {
            switch (Properties.Settings.Default["language"])

            {
                case "english":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    break;
                case "vietnamese":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VI");
                    break;
                default:
                    break;
            }
            InitializeComponent();
        }
        private void AppFrame_Load(object sender, EventArgs e)
        {
            Resolution objFormResizer = new Resolution();
            //objFormResizer.ResizeForm(this, 768, 1024);
            objFormResizer.ResizeForm(this, 1080, 1920);

            // Stack up quotation
            switch (Properties.Settings.Default["language"])
            {

                case "english":
                    englishToolStripMenuItem.Checked = true;
                    vietnameseToolStripMenuItem.Checked = false;
                    Quotes.English quote = new Quotes.English();
                    lbQuotation.Text = quote.Wisdom;
                    break;
                case "vietnamese":
                    englishToolStripMenuItem.Checked = false;
                    vietnameseToolStripMenuItem.Checked = true;
                    Quotes.Vietnamese quote_vi = new Quotes.Vietnamese();
                    lbQuotation.Text = quote_vi.Wisdom;
                    break;
                default:
                    break;
            }
            //Determine data folder existen in ApplicationData
            if (!Directory.Exists(dicconProp.dicconApplicationDataPath))
            {
                Directory.CreateDirectory(dicconProp.dicconApplicationDataPath);
            };
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

                    break;
            }
            if (Properties.Settings.Default["userID"].ToString() != "none")
            {
                accountToolStripMenuItem.Visible = true;
                backUpSyncToolStripMenuItem.Visible = true;
                logInWithGoogleToolStripMenuItem.Visible = false;
            }


            topPanel.BackColor = dicconProp.AccentColor;
            topControlPanel.BackColor = dicconProp.AccentColor;
            btDictionary.BackColor = dicconProp.ColorA8;
            btDonate.BackColor = dicconProp.ColorA8;
            btTimeline.BackColor = dicconProp.ColorA8;
            btNotes.BackColor = dicconProp.ColorA8;
            btCommunity.BackColor = dicconProp.ColorA8;
        }





        public class Resolution
        {
            float heightRatio = new float();
            float widthRatio = new float();
            int standardHeight, standardWidth;
            public void ResizeForm(Form objForm, int DesignerHeight, int DesignerWidth)
            {
                standardHeight = DesignerHeight;
                standardWidth = DesignerWidth;
                int presentHeight = Screen.PrimaryScreen.WorkingArea.Height;//.Bounds.Height;
                int presentWidth = Screen.PrimaryScreen.Bounds.Width;
                heightRatio = (float)((float)presentHeight / (float)standardHeight);
                widthRatio = (float)((float)presentWidth / (float)standardWidth);
                objForm.AutoScaleMode = AutoScaleMode.None;
                objForm.Scale(new SizeF(widthRatio, heightRatio));
                foreach (Control c in objForm.Controls)
                {
                    if (c.HasChildren)
                    {
                        ResizeControlStore(c);
                    }
                    else
                    {
                        c.Font = new Font(c.Font.FontFamily, c.Font.Size * heightRatio, c.Font.Style, c.Font.Unit, ((byte)(0)));
                    }
                }
                objForm.Font = new Font(objForm.Font.FontFamily, objForm.Font.Size * heightRatio, objForm.Font.Style, objForm.Font.Unit, ((byte)(0)));
            }

            private void ResizeControlStore(Control objCtl)
            {
                if (objCtl.HasChildren)
                {
                    foreach (Control cChildren in objCtl.Controls)
                    {
                        if (cChildren.HasChildren)
                        {
                            ResizeControlStore(cChildren);

                        }
                        else
                        {
                            cChildren.Font = new Font(cChildren.Font.FontFamily, cChildren.Font.Size * heightRatio, cChildren.Font.Style, cChildren.Font.Unit, ((byte)(0)));
                        }
                    }
                    objCtl.Font = new Font(objCtl.Font.FontFamily, objCtl.Font.Size * heightRatio, objCtl.Font.Style, objCtl.Font.Unit, ((byte)(0)));
                }
                else
                {
                    objCtl.Font = new Font(objCtl.Font.FontFamily, objCtl.Font.Size * heightRatio, objCtl.Font.Style, objCtl.Font.Unit, ((byte)(0)));
                }
            }
        }





        /// <summary>
        /// Change Red and Green background of Rounded-Label to a darker shade of  color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoundedLabel_MouseEnter(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_MouseEnter(sender, e);
        }
        /// <summary>
        /// Change Red and Green background of Rounded-Label to a lighter shade of  color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoundedLabel_MouseLeave(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_MouseLeave(sender, e);
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
                if (formName == item)
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
            logo.Image = Properties.Resources.diccon_32_2;
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
            if (staredForm == "default")
            {
                btStar.IconColor = Color.Gold;
                btStar.IconFont = IconFont.Solid;
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
            if (Properties.Settings.Default["userID"].ToString() != "none")
            {
                if (yawaForm != null)
                {

                    openForm(yawaForm);
                }
                else
                {
                    yawaForm = new yawa();
                    openForm(yawaForm);
                }
            }
            else
            {
                MessageBox.Show(dicconProp.loginRequest);
            }
        }

        private void timeLineDetector_Tick(object sender, EventArgs e)
        {
            if (dicconProp.wordFromTimeline != "")
            {
                btDictionary_Click(null, null);
            }
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(dicconProp.githubPath);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (settingForm != null)
            {

                openForm(settingForm);
            }
            else
            {
                settingForm = new settings();
                openForm(settingForm);
            }
        }

        private void notificationDetector_Tick(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.alert_wav);
            soundPlayer.Play();
            notificationDetector.Enabled = false;
        }

        private void logInWithGoogleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginForm != null)
            {

                openForm(loginForm);
            }
            else
            {
                loginForm = new login();
                openForm(loginForm);
            }
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginForm != null)
            {

                openForm(loginForm);
            }
            else
            {
                loginForm = new login();
                openForm(loginForm);
            }
        }

        private void backUpSyncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string timelineLocalContents = "";
            string timelineOnlineContents = "";
            connectivity connectivity = new connectivity();
            if (connectivity.isOnline())
            {
                try
                {
                    if (File.Exists(dicconProp.historyFileName))
                    {
                        // Get both local and online data together, and then mix them up, filter out doulicate and push online and local
                        timelineLocalContents = File.ReadAllText(dicconProp.historyFileName);
                        string getOnlineQueryString = @"Select Timeline from dbo.DicconUser where Id=" + dicconProp.userID;
                        SQLHandler sqlHandler = new SQLHandler();
                        DataTable dataTable = sqlHandler.Select(getOnlineQueryString);
                        timelineOnlineContents = dataTable.Rows[0][0].ToString();
                        // Combine two string
                        string combinedContents = timelineLocalContents + "#" + timelineOnlineContents;
                        string[] rawList = combinedContents.Split('#');
                        List<string> rawList_1 = new List<string>();
                        foreach (var item in rawList)
                        {
                            rawList_1.Add(item.ToString());
                        }
                        // Remove doublicate by Distinct() function in LINQ
                        List<string> rawList_2 = rawList_1.Distinct().ToList();
                        string outList = string.Join("#", rawList_2);
                        // Update new data to online disk
                        string updateQueryString = "UPDATE dbo.DicconUser  SET Timeline = '" + outList + "' Where Id=" + dicconProp.userID;
                        sqlHandler.Update(updateQueryString);
                        // Update new data to local disk
                        StreamWriter history = new StreamWriter(dicconProp.historyFileName);
                        history.Write(outList);
                        history.Close();
                    }
                    else
                    {
                        // If local file not exist, we get online data and write it to local
                        string getOnlineQueryString = @"Select Timeline from dbo.DicconResources where Id=" + dicconProp.userID;
                        SQLHandler sqlHandler = new SQLHandler();
                        DataTable dataTable = sqlHandler.Select(getOnlineQueryString);
                        timelineOnlineContents = dataTable.Rows[0][1].ToString();
                        // Update new data to local disk
                        StreamWriter history = new StreamWriter(dicconProp.historyFileName);
                        history.Write(timelineOnlineContents);
                        history.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(dicconProp.backupError);


                }

            }
            else
            {
                MessageBox.Show(dicconProp.internetError);
            }


        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["language"] = "english";
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void vietnameseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["language"] = "vietnamese";
            Properties.Settings.Default.Save();
            Application.Restart();
        }
    }
}
