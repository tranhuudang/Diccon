using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccon
{
    public class wordFunction
    {
        private string preWord = "none";
        private string onlineUrlOfUk;
        private string onlineUrlOfUs;
        //private string offlineAddress="none";
        private string outWord;
        private string preParagraph = " ";
        private string outParagraph = " ";

        public string PreWord { get => preWord; set => preWord = value; }
        public string OutWord { get => outWord; set => outWord = value; }
        public string PreParagraph { get => preParagraph; set => preParagraph = value; }
        public string OutParagraph { get => outParagraph; set => outParagraph = value; }

        // Xử lí Related Text
        public ArrayList RelatedText(string Word, string[] InputArray)
        {

            ArrayList RelatedTextSource = new ArrayList();
            string[] BunchRelated = null;
            int arrIndex = 0;
            int LimitOfList = 0; // limit of list is 28
            int max = 28;
            string SearchText = Word + "--";
            foreach (string text in InputArray)
            {
                if (text.Contains(SearchText))
                {
                    BunchRelated = InputArray[arrIndex].Substring(SearchText.Length + 1).Split(" ".ToCharArray());
                    foreach (string textInBunch in BunchRelated)
                    {
                        RelatedTextSource.Add(textInBunch);
                        LimitOfList++;
                        if (LimitOfList == max) break;
                    }
                    return RelatedTextSource;

                }
                arrIndex++;
            }
            return RelatedTextSource;


        }
        // Xử lí đầu ra cho Translate Paragraph
        public string TranslateParagraphProcess()
        {
            try
            {
                //translate.google.com/?sl=en&tl=vi&text=english%20is%20a%20language%20in%20the%20world&op=translate
                // lỗi này đã được bắt và không nhất thiết phải sửa nữa
                outParagraph = preParagraph.Replace(" ", "%20");
                outParagraph = "http://translate.google.com/?sl=en&tl=vi&text=" + outParagraph + "&op=translate";
                return outParagraph;
            }
            catch (Exception error)
            {
                error.ToString();
                outParagraph = "http://translate.google.com";
            }
            return outParagraph;
        }
        // Xử lí từ đầu vào thành một từ chuẩn cho quá trình tìm kiếm từ trong Database
        public string SearchWordProcess()
        {
            outWord = preWord;
            outWord = outWord.ToLower();
            outWord = outWord.Replace("\n", "").Replace("\r", ""); // delete \n in c#
            return outWord;
        }
        // https://github.com/zeroclubvn/US-Pronunciation/raw/main/A/us/Affected.mp3
        public string OnlineUrlProcess(string UsOrUk)
        {
            string firstLetter = PreWord.Substring(0, 1).ToUpper();
            string afterFirstLetter = PreWord.Substring(1);
            string url = "https://github.com/zeroclubvn/US-Pronunciation/raw/main/" + firstLetter + "/us/" + firstLetter + afterFirstLetter + ".mp3";
            return url;
        }
        
        public int countWord(string text)
        {
            string pattern = "[^\\w]";
            //get all spaces and other signs, like: '.' '?' '!'
            string input = text;
            string[] words = null;
            int i = 0;
            int count = 0;
            Console.WriteLine(input);
            words = Regex.Split(input, pattern, RegexOptions.IgnoreCase);
            for (i = words.GetLowerBound(0); i <= words.GetUpperBound(0); i++)
            {
                if (words[i].ToString() == string.Empty)
                    count = count - 1;
                count = count + 1;
            }
            return count;
        }

        private int CountWordLineOfRichTextBox(RichTextBox richtextbox)
        {
            return richtextbox.GetLineFromCharIndex(richtextbox.TextLength);
        }
    }
}
