using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccon
{
    static class dicconProp
    {
        public static string TextDataFromResources = Properties.Resources.Envi;
        public static string[] splitedText = TextDataFromResources.Split("@".ToCharArray());
        // botton height use to control the panel when open bottom menu
        public static int bottomPanel_DefaultHeight = 70;
        public static int bottomPanel_ExpandedHeight = 150;
        public static Color default_addNote_BackColor = Color.FromArgb(255, 192, 128);
        public static Color hover_addNote_BackColor = Color.FromArgb(242, 203, 164);
        public static string resourcesFolder = @"Resources\";
        public static string updateAvailableMessage = "";
        public static string noUpdateAvailableMessage = "You're running the lastest version of Diccon!";

    }
}
