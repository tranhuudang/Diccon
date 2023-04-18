using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Diccon
{
    static class DicconProp
    {
        private static string caption = "Diccon";
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
        private static Dictionary<string, List<string>> synonymCache = new Dictionary<string, List<string>>();
        private static Dictionary<string, string> cachedImageUrls = new Dictionary<string, string>();

        private static string applicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string dicconApplicationDataPath = ApplicationDataPath + @"\Diccon";
        private static string textDataFromResources = Properties.Resources.Envi;
        private static string spellingCorrectorDictionary = Properties.Resources.spellingCorrectorDictionary;
        private static string[] splitedText = TextDataFromResources.Split("@".ToCharArray());
        // botton height use to control the panel when open bottom menu
        private static int bottomPanel_DefaultHeight = 60;
        private static int bottomPanel_ExpandedHeight = 140;
        private static bool firstTimeOpen = true;
        private static string connectionString = "Server= 112.78.2.154;Database=zer42982_ZeroClubOne;Trusted_Connection=False;MultipleActiveResultSets=true;User ID=zer42982_study;Password=7wYi02_w";


        private static string resourcesFolder = DicconApplicationDataPath + @"\Resources\";
        private static string currentWord;
        private static string currentTranslatedWord;
        private static int maximumSynonym = 10;
        private static string listenTimeInString = "00:00:07";
        private static bool isFromPixabay = true;

        private const char separateCharacterInHistory = '#';
        private static string historyFileName = DicconApplicationDataPath + @"\History.ini";
        private static string userInfoFileName = DicconApplicationDataPath + @"\UserInfo.ini";
        private static string wordFromTimeline = "";
        private static string wordFromSynonym = "";
        private static string userID = "";
        private static string userEmail = "";

        public static char SeparateCharacterInHistory => separateCharacterInHistory;

        public static string HistoryFileName { get => historyFileName; set => historyFileName = value; }
        public static string UserInfoFileName { get => userInfoFileName; set => userInfoFileName = value; }
        public static string WordFromTimeline { get => wordFromTimeline; set => wordFromTimeline = value; }
        public static string WordFromSynonym { get => wordFromSynonym; set => wordFromSynonym = value; }
        public static string UserID { get => userID; set => userID = value; }
        public static string UserEmail { get => userEmail; set => userEmail = value; }
        public static string ResourcesFolder { get => resourcesFolder; set => resourcesFolder = value; }
        public static string CurrentWord { get => currentWord; set => currentWord = value; }
        public static string CurrentTranslatedWord { get => currentTranslatedWord; set => currentTranslatedWord = value; }
        public static int MaximumSynonym { get => maximumSynonym; set => maximumSynonym = value; }
        public static string ListenTimeInString { get => listenTimeInString; set => listenTimeInString = value; }
        public static bool IsFromPixabay { get => isFromPixabay; set => isFromPixabay = value; }
        public static string ApplicationDataPath { get => applicationDataPath; set => applicationDataPath = value; }
        public static string DicconApplicationDataPath { get => dicconApplicationDataPath; set => dicconApplicationDataPath = value; }
        public static string TextDataFromResources { get => textDataFromResources; set => textDataFromResources = value; }
        public static string SpellingCorrectorDictionary { get => spellingCorrectorDictionary; set => spellingCorrectorDictionary = value; }
        public static string[] SplitedText { get => splitedText; set => splitedText = value; }
        public static int BottomPanel_DefaultHeight { get => bottomPanel_DefaultHeight; set => bottomPanel_DefaultHeight = value; }
        public static int BottomPanel_ExpandedHeight { get => bottomPanel_ExpandedHeight; set => bottomPanel_ExpandedHeight = value; }
        public static bool FirstTimeOpen { get => firstTimeOpen; set => firstTimeOpen = value; }
        public static string ConnectionString { get => connectionString; set => connectionString = value; }
        public static Dictionary<string, List<string>> SynonymCache { get => synonymCache; set => synonymCache = value; }
        public static Dictionary<string, string> CachedImageUrls { get => cachedImageUrls; set => cachedImageUrls = value; }
        public static string Caption { get => caption; set => caption = value; }

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
