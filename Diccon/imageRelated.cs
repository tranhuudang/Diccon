using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccon
{
    internal class imageRelated
    {
        Random random = new Random();
        int imageIndex = 0;
        public async Task<string> getImageUrl(string word)
        {
            //string API_Key = "25829393-af32bf17ec8386b5941fb5f8f";
            imageIndex= random.Next(0, 3);
            string rawContent;
            string imageUrl="none";
            try
            {
                HttpClient client = new HttpClient();
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, @"https://pixabay.com/api/?key=25829393-af32bf17ec8386b5941fb5f8f&q=" + word + @"&image_type=photo");
                using (var responseMessage = await client.SendAsync(request))
                {
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        rawContent = await responseMessage.Content.ReadAsStringAsync();
                        JsonNode jsonContent = JsonNode.Parse(rawContent);
                        imageUrl = jsonContent["hits"][imageIndex++]["webformatURL"].GetValue<string>();

                    }

                }
                return imageUrl;
            }
            catch (Exception)
            {

                return "none";
            }
            
        }
    }
}
