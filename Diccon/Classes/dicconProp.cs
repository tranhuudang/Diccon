using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Diccon
{
    static class dicconProp
    {
        public static string caption = "Diccon";
        public class LanguageType
        {
            public const string English = "english";
            public const string Vietnamese = "vietnamese";
        }
        public static string language = Properties.Settings.Default["language"].ToString();
        public static int A = 200;
        public static int R = 0;
        public static int G = 120;
        public static int B = 215;
        public static Color AccentColor = GetAccentColor();
        // higher is lighter 0.9 ligher than 0.1
        public static Color ColorA9 = Color.FromArgb((int)(R + (0.9 * (255 - R))), (int)(G + Math.Floor(0.9 * (255 - G))), (int)(B + Math.Floor(0.9 * (255 - B))));
        public static Color ColorA8 = Color.FromArgb((int)(R + (0.8 * (255 - R))), (int)(G + Math.Floor(0.8 * (255 - G))), (int)(B + Math.Floor(0.8 * (255 - B))));
        public static Color ColorA7 = Color.FromArgb((int)(R + (0.7 * (255 - R))), (int)(G + Math.Floor(0.7 * (255 - G))), (int)(B + Math.Floor(0.7 * (255 - B))));
        public static Color ColorA5 = Color.FromArgb((int)(R + (0.5 * (255 - R))), (int)(G + Math.Floor(0.5 * (255 - G))), (int)(B + Math.Floor(0.5 * (255 - B))));
        public static Color ColorA3 = Color.FromArgb((int)(R + (0.3 * (255 - R))), (int)(G + Math.Floor(0.3 * (255 - G))), (int)(B + Math.Floor(0.3 * (255 - B))));
        public static Color ColorA1 = Color.FromArgb((int)(R + (0.1 * (255 - R))), (int)(G + Math.Floor(0.1 * (255 - G))), (int)(B + Math.Floor(0.1 * (255 - B))));

        public static string applicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string dicconApplicationDataPath = applicationDataPath + @"\Diccon";
        public static string TextDataFromResources = Properties.Resources.Envi;
        public static string SpellingCorrectorDictionary = Properties.Resources.spellingCorrectorDictionary;
        public static string[] splitedText = TextDataFromResources.Split("@".ToCharArray());
        // botton height use to control the panel when open bottom menu
        public static int bottomPanel_DefaultHeight = 60;
        public static int bottomPanel_ExpandedHeight = 140;
        public static bool firstTimeOpen = true;
        public static string connectionString = "Server= 112.78.2.154;Database=zer42982_ZeroClubOne;Trusted_Connection=False;MultipleActiveResultSets=true;User ID=zer42982_study;Password=7wYi02_w";

        public static Color default_addNote_BackColor = Color.FromArgb(255, 192, 128);
        public static Color hover_addNote_BackColor = Color.FromArgb(242, 203, 164);
        public static string resourcesFolder = dicconApplicationDataPath + @"\Resources\";
        public static string currentWord;
        public static string currentTranslatedWord;
        public static int maximumSynonym = 10;
        public static List<string> currentSynonymList = new List<string>();
        public static int listenTimeInNumber = 7;
        public static string listenTimeInString = "00:00:07";
        public static string currentImageLink = "none";
        public static bool isFromPixabay = true;
       
        public static char saparateCharactorInHistory = '#';
        public static string historyFileName = dicconApplicationDataPath + @"\History.ini";
        public static string noteFilePath = dicconApplicationDataPath + @"\Note.xml";
        public static string wordFromTimeline = "";
        public static string wordFromSynonym = "";
        public static string githubPath = "https://github.com/tranhuudang";
        public static string githubProjectPath = "https://github.com/zeroclubvn/Diccon";
        public static string githubIssuesPath = "https://github.com/tranhuudang/Diccon/issues";
        public static string enableFlashClipboard = Properties.Settings.Default["FlashClipboard"].ToString();
        public static string userID = Properties.Settings.Default["userID"].ToString();
        /// <summary>
        ///  WebBrowser used for html2Rtf Converter
        /// </summary>

        /// <summary>
        /// Duo language notifications
        /// </summary>
        public static string promptLogin =
             language == LanguageType.English ? "You're not logged in yet. Please login or register a new account to use this function. "
            : "Bạn chưa Đăng nhập vào ứng dụng. Vui lòng Đăng nhập hoặc Tạo tài khoản mới để sử dụng tính năng này.";
        public static string promptMissingWord =
             language == LanguageType.English ? "This word is missing from our data. It had been automaticly reported, we will check it and make sure to update the data as soon as possible."
            : "Không tìm thấy từ này trong ứng dụng. Hệ thống đã tự động báo cáo về trung tâm để xác minh hoặc bổ sung ngữ nghĩa trong trường hợp dữ liệu bị thiếu.";
        public static string errorInternet =
             language == LanguageType.English ? "Unfortunately, we can't connect to the internet at the moment."
           : "Thật không may, ứng dụng không thể kết nối với hệ thống ở thời điểm hiện tại.";
        public static string errorBackup =
             language == LanguageType.English ? "A error occur during Back up & Sync process. Try again or contact to us for help."
            : "Có lỗi trong quá trình Sao lưu và đồng bộ dữ liệu. Vui lòng thử lại sau hoặc liên hệ với chúng tôi về sự cố.";
        public static string promptDeleteHistoryFile =
             language == LanguageType.English ? "Do you really want remove timeline out of local device?"
            : "Bạn có thực sự muốn xóa lịch sử khỏi bộ nhớ thiết bị này?";
        public static string errorDeleteHistoryFile =
             language == LanguageType.English ? "We can't remove timeline because of an unexpected error."
            : "Một lỗi không xác định xảy ra trong quá trình xóa bộ nhớ.";
        public static string promptSyncedSuccess =
             language == LanguageType.English ? "Your data had been synced successfully."
            : "Dữ liệu của bạn đã được đồng bộ.";
        public static string errorUnknown =
            language == LanguageType.English ? "Unexpected error."
            : "Lỗi chưa xác định";
        
        public static string pathAccentColor = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\DWM";
        /// <summary>
        /// Gets the currently applied Windows accent color.
        /// </summary>
        private static Color GetAccentColor()
        {
            
            try
            {
              

                return Color.FromArgb(200, 0, 120, 215);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString()) ;
                // default blue color
                return Color.FromArgb(200, 0, 120, 215);
            }
        }
        /// <summary>
        /// Change Red and Green background of Rounded-Label to a darker shade of  color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void RoundedLabel_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                RoundedLabel roundedLabel = (sender as RoundedLabel);
                int A = roundedLabel.BackColor.A <= 100 ? roundedLabel.BackColor.A + 100 : roundedLabel.BackColor.A;
                int R = roundedLabel.BackColor.R;
                int G = roundedLabel.BackColor.G;
                int B = roundedLabel.BackColor.B;

                roundedLabel.BackColor = ColorA9;
            }
            catch (Exception)
            {
            }

        }
        /// <summary>
        /// Change Red and Green background of Rounded-Label to a lighter shade of  color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void RoundedLabel_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                RoundedLabel roundedLabel = (sender as RoundedLabel);
                int A = roundedLabel.BackColor.A > 100 ? roundedLabel.BackColor.A - 100 : roundedLabel.BackColor.A;
                int R = roundedLabel.BackColor.R;
                int G = roundedLabel.BackColor.G;
                int B = roundedLabel.BackColor.B;

                roundedLabel.BackColor = ColorA8;
            }
            catch (Exception)
            {

            }


        }
        /// <summary>
        /// Change Red and Green background of Rounded-Label to a darker shade of  color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void RoundedLabel_Darker_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                Control roundedLabel = (sender as Control);
                int A = roundedLabel.BackColor.A <= 100 ? roundedLabel.BackColor.A + 100 : roundedLabel.BackColor.A;
                int R = roundedLabel.BackColor.R;
                int G = roundedLabel.BackColor.G;
                int B = roundedLabel.BackColor.B;

                roundedLabel.BackColor = ColorA5;
            }
            catch (Exception)
            {
            }

        }
        /// <summary>
        /// Change Red and Green background of Rounded-Label to a lighter shade of  color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void RoundedLabel_Darker_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                Control roundedLabel = (sender as Control);
                int A = roundedLabel.BackColor.A > 100 ? roundedLabel.BackColor.A - 100 : roundedLabel.BackColor.A;
                int R = roundedLabel.BackColor.R;
                int G = roundedLabel.BackColor.G;
                int B = roundedLabel.BackColor.B;

                roundedLabel.BackColor = ColorA3;
            }
            catch (Exception)
            {

            }


        }
        public static void Control_MouseEnter(object sender, EventArgs e)
        {
            Control control = (sender as Control);
            int X = control.Location.X;
            int Y = control.Location.Y - 2;
            control.Location = new Point(X, Y);
        }
        /// <summary>
        /// Change position of PictureBox to create a illusion that the box is push down a little bit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Control_MouseLeave(object sender, EventArgs e)
        {
            Control control = (sender as Control);
            int X = control.Location.X;
            int Y = control.Location.Y + 2;
            control.Location = new Point(X, Y);
        }
    }
}
