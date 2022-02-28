using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Diccon
{
    internal class sysnonym
    {



        public async Task<List<string>> getSynonymListAsync(string word)
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
            using (var response = await client.SendAsync(request))
            {
                if(response.IsSuccessStatusCode)
                {
                    body = await response.Content.ReadAsStringAsync();
                    JsonNode JsonResponse = JsonNode.Parse(body);

                    for (int i = 0; i < dicconProp.maximumSynonym; i++)
                    {
                        synonymList.Add(JsonResponse["data"]["synonyms"][i][0].GetValue<string>());
                    }
                    return synonymList;
                }
               else
                {
                    return null;
                }

            }
            
        }
    }
}
