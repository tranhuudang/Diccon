using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Diccon
{
    static class DicconProp
    {
        public static string caption = "Diccon";
        public enum LanguageType
        {
            English,
            Vietnamese
        }
        public static LanguageType Language = LanguageType.English;
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

        //Cache the results of the database query in memory to avoid querying the database every time the method is called for the same word
        public static Dictionary<string, List<string>> SynonymCache = new Dictionary<string, List<string>>();
        public static Dictionary<string, string> CachedImageUrls = new Dictionary<string, string>();

        public static string ApplicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string DicconApplicationDataPath = ApplicationDataPath + @"\Diccon";
        public static string TextDataFromResources = Properties.Resources.Envi;
        public static string SpellingCorrectorDictionary = Properties.Resources.spellingCorrectorDictionary;
        public static string[] splitedText = TextDataFromResources.Split("@".ToCharArray());
        // botton height use to control the panel when open bottom menu
        public static int BottomPanel_DefaultHeight = 60;
        public static int BottomPanel_ExpandedHeight = 140;
        public static bool FirstTimeOpen = true;
        public static string ConnectionString = "Server= 112.78.2.154;Database=zer42982_ZeroClubOne;Trusted_Connection=False;MultipleActiveResultSets=true;User ID=zer42982_study;Password=7wYi02_w";

        public static Color Default_addNote_BackColor = Color.FromArgb(255, 192, 128);
        public static Color Hover_addNote_BackColor = Color.FromArgb(242, 203, 164);
        public static string ResourcesFolder = DicconApplicationDataPath + @"\Resources\";
        public static string CurrentWord;
        public static string CurrentTranslatedWord;
        public static int MaximumSynonym = 10;
        public static List<string> CurrentSynonymList = new List<string>();
        public static int ListenTimeInNumber = 7;
        public static string ListenTimeInString = "00:00:07";
        public static string CurrentImageLink = "none";
        public static bool IsFromPixabay = true;

        public static char SaparateCharactorInHistory = '#';
        public static string HistoryFileName = DicconApplicationDataPath + @"\History.ini";
        public static string UserInfoFileName = DicconApplicationDataPath + @"\UserInfo.ini";
        public static string NoteFilePath = DicconApplicationDataPath + @"\Note.xml";
        public static string WordFromTimeline = "";
        public static string WordFromSynonym = "";
        public static string GithubPath = "https://github.com/tranhuudang";
        public static string GithubProjectPath = "https://github.com/zeroclubvn/Diccon";
        public static string GithubIssuesPath = "https://github.com/tranhuudang/Diccon/issues";
        public static string UserID = "";
        public static string UserEmail = "";
        /// <summary>
        ///  WebBrowser used for html2Rtf Converter
        /// </summary>

        /// <summary>
        /// Duo language notifications
        /// </summary>
        public static string PromptLogin =
             Language == LanguageType.English ? "You're not logged in yet. Please login or register a new account to use this function. "
            : "Bạn chưa Đăng nhập vào ứng dụng. Vui lòng Đăng nhập hoặc Tạo tài khoản mới để sử dụng tính năng này.";
        public static string PromptMissingWord =
             Language == LanguageType.English ? "This word is missing from our data. It had been automatically reported, we will check it and make sure to update the data as soon as possible."
            : "Không tìm thấy từ này trong ứng dụng. Hệ thống đã tự động báo cáo về trung tâm để xác minh hoặc bổ sung ngữ nghĩa trong trường hợp dữ liệu bị thiếu.";
        public static string ErrorInternet =
             Language == LanguageType.English ? "Unfortunately, we can't connect to the internet at the moment."
           : "Thật không may, ứng dụng không thể kết nối với hệ thống ở thời điểm hiện tại.";
        public static string ErrorBackup =
             Language == LanguageType.English ? "A error occur during Back up & Sync process. Try again or contact to us for help."
            : "Có lỗi trong quá trình Sao lưu và đồng bộ dữ liệu. Vui lòng thử lại sau hoặc liên hệ với chúng tôi về sự cố.";
        public static string PromptDeleteHistoryFile =
             Language == LanguageType.English ? "Do you really want remove timeline out of local device?"
            : "Bạn có thực sự muốn xóa lịch sử khỏi bộ nhớ thiết bị này?";
        public static string ErrorDeleteHistoryFile =
             Language == LanguageType.English ? "We can't remove timeline because of an unexpected error."
            : "Một lỗi không xác định xảy ra trong quá trình xóa bộ nhớ.";
        public static string PromptSyncedSuccess =
             Language == LanguageType.English ? "Your data had been synced successfully."
            : "Dữ liệu của bạn đã được đồng bộ.";
        public static string ErrorUnknown =
            Language == LanguageType.English ? "Unexpected error."
            : "Lỗi chưa xác định";
        public static string LogOutError =
            Language == LanguageType.English ? "Unexpected error when trying to log out."
            : "Lỗi xảy ra khi đăng xuất, vui lòng thử lại sau";

        public static string PathAccentColor = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\DWM";
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
                MessageBox.Show(e.ToString());
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
