using System.Net.Http;
using System.Threading.Tasks;

namespace NgenTest
{
    public class Ngen
    {
        public class Webrequest
        {
            public async Task<string> GetTestSiteAsync()
            {
                try
                {
                    return await new HttpClient().GetStringAsync("https://example.com");
                }
                catch
                {
                    return default;
                }
            }
        }
    }
}
