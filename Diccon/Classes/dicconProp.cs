using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Diccon
{
    static class dicconProp
    {
        public static string TextDataFromResources = Properties.Resources.Envi;
        public static string[] splitedText = TextDataFromResources.Split("@".ToCharArray());
        // botton height use to control the panel when open bottom menu
        public static int bottomPanel_DefaultHeight = 60;
        public static int bottomPanel_ExpandedHeight = 150;
        public static Color default_addNote_BackColor = Color.FromArgb(255, 192, 128);
        public static Color hover_addNote_BackColor = Color.FromArgb(242, 203, 164);
        public static string resourcesFolder = @"Resources\";
        public static string updateAvailableMessage = "New version available! Do you want to download it now?";
        public static string noUpdateAvailableMessage = "You're running the lastest version of Diccon!";
        public static string updateInfo = "https://raw.githubusercontent.com/tranhuudang/Diccon/master/Diccon/Setup%20and%20Update/UpdateInfo.xml";
        public static string downloadSetupCompleteMessage = "Diccon Updater is ready to install new version of Diccon!";
        public static string setupName = "DicconSetup.msi";
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
        public static string historyFileName= "History.ini";
        public static string noteFilePath=@"Note.xml";

        /// <summary>
        /// Change Red and Green background of Rounded-Label to a darker shade of  color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void RoundedLabel_MouseEnter(object sender, EventArgs e)
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
        public static void RoundedLabel_MouseLeave(object sender, EventArgs e)
        {
            RoundedLabel roundedLabel = (sender as RoundedLabel);
            int R = roundedLabel.BackColor.R <= 205 ? roundedLabel.BackColor.R + 50 : roundedLabel.BackColor.R;
            int G = roundedLabel.BackColor.G <= 205 ? roundedLabel.BackColor.G + 50 : roundedLabel.BackColor.G;
            int B = roundedLabel.BackColor.B;

            roundedLabel.BackColor = Color.FromArgb(R, G, B);
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
