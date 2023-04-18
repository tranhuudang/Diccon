using System;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Diccon
{
    internal class ImageRelated
    {
        private static readonly HttpClient _client = new HttpClient();
        Random random = new Random();
        int imageIndex = 0;
        public async Task<string> GetImageUrl(string word)
        {
            imageIndex = random.Next(0, 3);
            string rawContent;
            string imageUrl = "none";
            // https://github.com/ZeroClubOfficial/English-Through-Pictures/raw/main/A/alarm.jpg
            string imageTestLink = "https://github.com/ZeroClubOfficial/English-Through-Pictures/raw/main/" + word.Substring(0, 1).ToUpper() + "/" + word + ".jpg";
            Connectivity connect = new Connectivity();
            var websiteAlive = await connect.IsWebsiteAlive(new Uri(imageTestLink));
            if (websiteAlive)
            {
                DicconProp.IsFromPixabay = false;
                return imageTestLink;
            }
            // Check if the image has been cached
            if (DicconProp.CachedImageUrls.ContainsKey(word))
            {
                imageUrl = DicconProp.CachedImageUrls[word];
                DicconProp.IsFromPixabay = true;
                return imageUrl;
            }
            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, @"https://pixabay.com/api/?key=25829393-af32bf17ec8386b5941fb5f8f&q=" + word + @"&image_type=photo");
                using (var responseMessage = await _client.SendAsync(request))
                {
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        rawContent = await responseMessage.Content.ReadAsStringAsync();
                        JsonNode jsonContent = JsonNode.Parse(rawContent);
                        imageUrl = jsonContent["hits"][imageIndex++]["webformatURL"].GetValue<string>();

                    }

                }
                // Cache the image URL
                DicconProp.CachedImageUrls[word] = imageUrl;
                DicconProp.IsFromPixabay = true;
                return imageUrl;
            }
            catch (Exception)
            {

                return "none";
            }

        }
    }
}
