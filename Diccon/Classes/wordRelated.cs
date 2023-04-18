using System;
using System.Text.RegularExpressions;

namespace Diccon
{
    public class WordRelated
    {
        private string _preWord;
        private string _outWord;

        public string PreWord { get => _preWord; set => _preWord = value; }
        public string OutWord { get => _outWord; set => _outWord = value; }

        public WordRelated(string word)
        {
            _preWord = word;
        }
        public WordRelated()
        {
        }
        // Xử lí từ đầu vào thành một từ chuẩn cho quá trình tìm kiếm từ trong Database
        public string SearchWordProcess()
        {
            _outWord = _preWord.ToLower().Trim();
            return _outWord;
        }
        /// <summary>
        /// Create link to sound track file of a word in Github
        /// </summary>
        /// <param name="UsOrUk"></param>
        /// <returns></returns>
        public string OnlineUrlPath(string UsOrUk)
        {
            // Sample link's format: https://github.com/zeroclubvn/US-Pronunciation/raw/main/A/us/Affected.mp3
            char firstLetter = char.ToUpper(PreWord[0]);
            string afterFirstLetter = PreWord.Substring(1);
            string url = $"https://github.com/zeroclubvn/US-Pronunciation/raw/main/{firstLetter}/us/{firstLetter}{afterFirstLetter}.mp3";
            return url;
        }

        public int CountWord(string text)
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
                if (string.IsNullOrEmpty(words[i].ToString()))
                    count = count - 1;
                count = count + 1;
            }
            return count;
        }

    }
}
