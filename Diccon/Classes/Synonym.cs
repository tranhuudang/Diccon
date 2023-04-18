using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Diccon
{
    internal class Synonym
    {
        private readonly SQLHandler _sqlHandler = new SQLHandler();

        private async Task<List<string>> GetSynonymFromDatabase(string word)
        {
            if (DicconProp.SynonymCache.ContainsKey(word))
            {
                return DicconProp.SynonymCache[word];
            }

            try
            {
                DataTable dataTable = await _sqlHandler.SelectAsync($"SELECT * FROM dbo.DicconSynonym WHERE Word='{word}'");
                if (dataTable != null)
                {
                    string result = dataTable.Rows[0][1].ToString();
                    List<string> synonyms = result.Split(',').ToList();
                    DicconProp.SynonymCache[word] = synonyms;
                    return synonyms;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }



        private async void WriteSynonymToDatabase(string word, string synonym)
        {
            try
            {
                await _sqlHandler.InsertAsync($"INSERT INTO dbo.DicconSynonym VALUES('{word.ToLower()}','{synonym}')");
            }
            catch (Exception)
            {

            }

        }

        public async Task<List<string>> GetSynonymListAsync(string word)
        {
            List<string> list = await GetSynonymFromDatabase(word) ?? await GetSynonymFromRapidAPIAsync(word);
            if (list != null)
            {
                WriteSynonymToDatabase(word, String.Join(",", list.ToArray()));
            }
            return list;

        }
        public async Task<List<string>> GetSynonymFromRapidAPIAsync(string word)
        {

            List<string> synonymList = new List<string>();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://synonyms-word-info.p.rapidapi.com/v1/synonyms?str=" + word),
                Headers =
                        {
                            { "x-rapidapi-host", "synonyms-word-info.p.rapidapi.com" },
                            { "x-rapidapi-key", "a10d63c67cmshd79f69a2d87629ap1e586djsna7cdee48e5de" },
                        },
            };
            string body;
            try
            {
                using (var response = await client.SendAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        body = await response.Content.ReadAsStringAsync();
                        JsonNode JsonResponse = JsonNode.Parse(body);

                        for (int i = 0; i < DicconProp.MaximumSynonym; i++)
                        {
                            try
                            {
                                synonymList.Add(JsonResponse["data"]["synonyms"][i][0].GetValue<string>());
                            }
                            catch (Exception)
                            {

                            }

                        }
                        return synonymList;
                    }
                    else
                    {
                        return null;
                    }

                }
            }
            catch (Exception)
            {
                return null;
            }


        }
    }
}
