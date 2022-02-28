using System.Collections.Generic;
using System.Drawing;

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
        public static string updateInfo = "https://raw.githubusercontent.com/zeroclubvn/Diccon/master/Diccon/Setup%20and%20Update/UpdateInfo.xml";
        public static string downloadSetupCompleteMessage = "Diccon Updater is ready to install new version of Diccon!";
        public static string setupName = "DicconSetup.msi";
        public static string currentWord;
        public static string currentTranslatedWord;
        public static int maximumSynonym = 10;
        public static List<string> currentSynonymList = new List<string>();
        public static string connectError = "The service is temporarily down, we'll try to connect it later on.";
        public static int listenTimeInNumber = 7;
        public static string listenTimeInString = "00:00:07";

    }
}
