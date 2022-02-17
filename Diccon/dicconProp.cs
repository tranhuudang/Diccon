using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccon
{
    static class dicconProp
    {
        //public static string envi_data_url = "https://github.com/zeroclubvn/English-Vietnamese/raw/main/EN-VI.txt";
        //public static string envi_data_filename = @"Resources\Data_envi";
        //public static string resource_directory = @"Resources";
        public static string TextDataFromResources = Properties.Resources.Envi;
        public static string[] splitedText = TextDataFromResources.Split("@".ToCharArray());
        public static int bottomPanel_DefaultHeight = 70;
        public static int bottomPanel_ExpandedHeight = 150;
    }
}
