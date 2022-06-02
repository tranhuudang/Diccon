using Diccon.Pages;
using FontAwesome.Sharp;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using WK.Libraries.WTL;
using static WK.Libraries.WTL.ThemeListener;

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
        public appFrame()
        {
            InitializeComponent();
        }
        // Giảm kích thước font chữ
        public void SetAllControlsFont(Control.ControlCollection ctrls, int minusFontSize)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl.Controls != null)
                    SetAllControlsFont(ctrl.Controls, minusFontSize);

                ctrl.Font = new Font("MS Reference Sans Serif", ctrl.Font.Size - minusFontSize);

            }
        }
        // Xóa nhòe chữ cho scale trên 100
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        // #####################################################################################################
        // Hàm và thủ tục này dùng để kiểm tra mức độ thu phóng của hệ điều hành
        // Qua đó cho phép người lập trình xử lí giao diện tốt hơn
        [System.Runtime.InteropServices.DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int GetDeviceCaps(IntPtr hDC, int nIndex);

        public enum DeviceCap
        {
            VERTRES = 10,
            DESKTOPVERTRES = 117
        }

        static double GetWindowsScreenScalingFactor(bool percentage = true)
        {
            //Create Graphics object from the current windows handle
            Graphics GraphicsObject = Graphics.FromHwnd(IntPtr.Zero);
            //Get Handle to the device context associated with this Graphics object
            IntPtr DeviceContextHandle = GraphicsObject.GetHdc();
            //Call GetDeviceCaps with the Handle to retrieve the Screen Height
            int LogicalScreenHeight = GetDeviceCaps(DeviceContextHandle, (int)DeviceCap.VERTRES);
            int PhysicalScreenHeight = GetDeviceCaps(DeviceContextHandle, (int)DeviceCap.DESKTOPVERTRES);
            //Divide the Screen Heights to get the scaling factor and round it to two decimals
            double ScreenScalingFactor = Math.Round((double)PhysicalScreenHeight / (double)LogicalScreenHeight, 2);
            //If requested as percentage - convert it
            if (percentage)
            {
                ScreenScalingFactor *= 100.0;
            }
            //Release the Handle and Dispose of the GraphicsObject object
            GraphicsObject.ReleaseHdc(DeviceContextHandle);
            GraphicsObject.Dispose();
            //Return the Scaling Factor
            return ScreenScalingFactor;
        }
        // #####################################################################################################


        private void AppFrame_Load(object sender, EventArgs e)
        {
            //Determine data folder existen in ApplicationData
            if (!Directory.Exists(dicconProp.dicconApplicationDataPath))
            {
                Directory.CreateDirectory(dicconProp.dicconApplicationDataPath);
            };
            //
            switch (GetWindowsScreenScalingFactor())
            {
                case 100: // 100% scaling

                    break;
                case 125: // 125% scaling

                    SetProcessDPIAware();
                    SetAllControlsFont(this.Controls, 4);
                    break;
                case 150: // 150% scaling
                    SetProcessDPIAware();
                    SetAllControlsFont(this.Controls, 5);
                    break;
            }
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
           

            topPanel.BackColor = dicconProp.AccentColor;
            topControlPanel.BackColor = dicconProp.AccentColor;
            btDictionary.BackColor = dicconProp.ColorA8;
            btDonate.BackColor = dicconProp.ColorA8;
            btTimeline.BackColor = dicconProp.ColorA8;
            btNotes.BackColor = dicconProp.ColorA8;
            btCommunity.BackColor = dicconProp.ColorA8;
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

        private void timeLineDetector_Tick(object sender, EventArgs e)
        {
            if(dicconProp.wordFromTimeline!="")
            {
                btDictionary_Click(null,null);
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
    }
}
