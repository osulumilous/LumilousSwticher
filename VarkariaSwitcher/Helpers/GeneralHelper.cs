using System.Net;
using System.Threading.Tasks;

namespace VarkariaSwitcher
{
    static class GeneralHelper
    {
        public async static Task<string> GetVarkariaAddressAsync()
        {
            using (var webClient = new WebClient())
            {
                string result = string.Empty;
                try
                {
                    var line = await webClient.DownloadStringTaskAsync(Constants.VarkariaIpApiAddress);
                    result = line;
                }
                catch { }
                return result.Trim();
            }
        }
    }
}