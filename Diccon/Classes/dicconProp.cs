using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WK.Libraries.WTL;

namespace Diccon
{
    static class dicconProp
    {
        
        public static int A = ThemeListener.AccentColor.A;
        public static int R = ThemeListener.AccentColor.R;
        public static int G = ThemeListener.AccentColor.G;
        public static int B = ThemeListener.AccentColor.B;
        public static Color AccentColor = ThemeListener.AccentColor;
        public static Color SecondaryColor = Color.FromArgb(A-180,R,G,B);
        public static Color ColorA25 = Color.FromArgb(25,R,G,B);
        public static Color ColorA50 = Color.FromArgb(50,R,G,B);
        public static Color ColorA100 = Color.FromArgb(100,R,G,B);
        public static Color ColorA150 = Color.FromArgb(150,R,G,B);
        public static Color ColorA200 = Color.FromArgb(200,R,G,B);
        //public static Color ForeColor = ThemeListener.
        public static string applicationDataPath =Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string dicconApplicationDataPath = applicationDataPath + @"\Diccon";
        public static string TextDataFromResources = Properties.Resources.Envi;
        public static string[] splitedText = TextDataFromResources.Split("@".ToCharArray());
        // botton height use to control the panel when open bottom menu
        public static int bottomPanel_DefaultHeight = 60;
        public static int bottomPanel_ExpandedHeight = 150;
        public static Color default_addNote_BackColor = Color.FromArgb(255, 192, 128);
        public static Color hover_addNote_BackColor = Color.FromArgb(242, 203, 164);
        public static string resourcesFolder = dicconApplicationDataPath + @"\Resources\";
        public static string updateAvailableMessage = "New version available! Do you want to download it now?";
        public static string noUpdateAvailableMessage = "You're running the lastest version of Diccon!";
        public static string updateInfo = "https://raw.githubusercontent.com/tranhuudang/Diccon/master/Diccon/Setup%20and%20Update/UpdateInfo.xml";
        public static string downloadSetupCompleteMessage = "Diccon Updater is ready to install new version of Diccon!";
        public static string setupName = dicconApplicationDataPath+ @"\DicconSetup.msi";
        public static string currentWord;
        public static string currentTranslatedWord;
        public static int maximumSynonym = 10;
        public static List<string> currentSynonymList = new List<string>();
        public static string connectError = "The service is temporarily down, we'll try to connect it later on.";
        public static int listenTimeInNumber = 7;
        public static string listenTimeInString = "00:00:07";
        public static string currentImageLink = "none";
        public static bool isFromPixabay = true;
        public static string internetError = "Unfortunately, we can't connect to the internet at the moment!";
        public static char saparateCharactorInHistory='#';
        public static string historyFileName = dicconApplicationDataPath + @"\History.ini";
        public static string noteFilePath = dicconApplicationDataPath + @"\Note.xml";
        public static string wordFromTimeline = "";
        public static string githubPath = "https://github.com/tranhuudang";
        public static string githubProjectPath = "https://github.com/zeroclubvn/Diccon";
        public static string githubIssuesPath = "https://github.com/tranhuudang/Diccon/issues";

        /// <summary>
        /// Change Red and Green background of Rounded-Label to a darker shade of  color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void RoundedLabel_MouseEnter(object sender, EventArgs e)
        {
            RoundedLabel roundedLabel = (sender as RoundedLabel);
            int A = roundedLabel.BackColor.A + 100;
            int R = roundedLabel.BackColor.R;
            int G = roundedLabel.BackColor.G;
            int B = roundedLabel.BackColor.B;

            roundedLabel.BackColor = Color.FromArgb(A, R, G, B);
        }
        /// <summary>
        /// Change Red and Green background of Rounded-Label to a lighter shade of  color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void RoundedLabel_MouseLeave(object sender, EventArgs e)
        {
            RoundedLabel roundedLabel = (sender as RoundedLabel);
            int A =roundedLabel.BackColor.A - 100;
            int R = roundedLabel.BackColor.R;
            int G = roundedLabel.BackColor.G;
            int B = roundedLabel.BackColor.B;

            roundedLabel.BackColor = Color.FromArgb(A, R, G, B);
            
        }
        public static void PictureBox_MouseEnter(object sender, EventArgs e)
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
        public static void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (sender as PictureBox);
            int X = pictureBox.Location.X;
            int Y = pictureBox.Location.Y + 2;
            pictureBox.Location = new Point(X, Y);
        }
    }
}
