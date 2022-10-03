using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows;

namespace Diccon
{
    internal class sysnonym
    {

        private List<string> getSynonymFromDatabase(string word)
        {
            try
            {
                SQLHandler sqlHandler = new SQLHandler();
                DataTable dataTable = sqlHandler.Select($"SELECT * FROM dbo.DicconSynonym WHERE Word='{word}'");
                if (dataTable != null)
                {
                    string result = dataTable.Rows[0][1].ToString();
                    return result.Split(',').ToList();
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

        private async void writeSynonymToDatabse(string word, string synonym)
        {
            try
            {
                SQLHandler sqlHandler = new SQLHandler();
                await sqlHandler.Insert($"INSERT INTO dbo.DicconSynonym VALUES('{word.ToLower()}','{synonym}')");
            }
            catch (Exception)
            {

            }
            
     }

        public async Task<List<string>> getSynonymListAsync(string word)
        {
            List<string> list = getSynonymFromDatabase(word);
           if (list == null)
            {
                list = await getSynonymFromRapidAPIAsync(word);
                if(list!= null)
                {
                    writeSynonymToDatabse(word, String.Join(",", list.ToArray()));
                }
                return list;
            }
            else
            {
                return list;
            }

        }
        public async Task<List<string>> getSynonymFromRapidAPIAsync(string word)
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

                        for (int i = 0; i < dicconProp.maximumSynonym; i++)
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
