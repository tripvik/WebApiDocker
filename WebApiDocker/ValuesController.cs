using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using static NgenTest.Ngen;

namespace WebApiDocker
{
    public class ValuesController : ApiController
    {
        public async Task<IEnumerable<string>> GetAsync()
        {

            var testSite = await new Webrequest().GetTestSiteAsync();
            return new List<string> { testSite, "Test2", "Test3" };
        }
    }
}
