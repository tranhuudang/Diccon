using System;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Diccon
{
    internal class Connectivity
    {
        private static readonly HttpClient _client = new HttpClient();
        public bool IsOnline()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 5000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> IsWebsiteAlive(Uri url)
        {
            if (IsOnline())
            {
                var checkingResponse = await _client.GetAsync(url);
                if (checkingResponse.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
            return false;

        }
    }
}
