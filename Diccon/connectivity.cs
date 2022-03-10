using System;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Diccon
{
    internal class connectivity
    {
        public bool isOnline()
        {
            try
            {
                System.Net.NetworkInformation.Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> isWebsiteAlive(Uri url)
        {
            if (isOnline())
            {
                HttpClient client = new HttpClient();
                var checkingResponse = await client.GetAsync(url);
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
