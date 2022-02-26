using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Diccon
{
    internal class onlineDictionary
    {
        public string word { get; set; }
        public string[] phonetics { get; set; }
        public string[] meanings { get; set; }
        public string license { get; set; }
        public string[] sourceUrls { get; set; }
    }
}
