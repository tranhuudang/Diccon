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
    public class wordRelated
    {
        private string preWord;
        private string outWord;

        public string PreWord { get => preWord; set => preWord = value; }
        public string OutWord { get => outWord; set => outWord = value; }

        public wordRelated(string word)
        {
            preWord = word;
        }
        public wordRelated()
        {
        }
        // Xử lí từ đầu vào thành một từ chuẩn cho quá trình tìm kiếm từ trong Database
        public string SearchWordProcess()
        {
            outWord = preWord;
            outWord = outWord.ToLower();
            outWord = outWord.Replace("\n", "").Replace("\r", ""); // delete \n in c#
            return outWord;
        }
        /// <summary>
        /// Create link to sound track file of a word in Github
        /// </summary>
        /// <param name="UsOrUk"></param>
        /// <returns></returns>
        public string OnlineUrlPath(string UsOrUk)
        {
            // https://github.com/zeroclubvn/US-Pronunciation/raw/main/A/us/Affected.mp3
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

    }
}
