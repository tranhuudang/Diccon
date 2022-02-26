using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroupDocs.Search;
using Json.Net;

namespace Diccon
{
    internal class synonyms
    {
        public synonyms()
        {
        }
        public string[] getSynonymsAsync(string word) 
        {
            string[] synonyms = new Index().Dictionaries.SynonymDictionary.GetSynonyms(word);
            return synonyms;

        }
    }
}
