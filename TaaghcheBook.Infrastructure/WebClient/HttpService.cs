using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaaghcheBook.Infrastructure.WebClient
{
    public class HttpService : IHttpService
    {
        public async Task<T?> Get<T>(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest() { Method = Method.Get};
            var result = await client.GetAsync<T>(request);
            return result;
        }
    }
}
