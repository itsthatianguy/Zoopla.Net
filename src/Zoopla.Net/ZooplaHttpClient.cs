using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Zoopla.Net
{
    public class ZooplaHttpClient
    {
        // Only have one instance which get's re-used (https://aspnetmonsters.com/2016/08/2016-08-27-httpclientwrong/)
        private static HttpClient _client = new HttpClient();

        public async Task<T> GetObject<T>(string url)
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            HttpResponseMessage response = await _client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseJson);
            }
            else
            {
                // Error?
            }
            return default(T);
        }
    }
}
