using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Zoopla.Net.Core.Models;

namespace Zoopla.Net.Core
{
    public class ZooplaHttpClient
    {
        // Only have one instance which get's re-used (https://aspnetmonsters.com/2016/08/2016-08-27-httpclientwrong/)
        private static readonly HttpClient _client = new HttpClient();

        public async Task<T> GetObject<T>(string url) where T : ResponseModelBase
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            var response = await _client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseJson);
            }
            else
            {
                var errorResponse = (T)Activator.CreateInstance(typeof(T));
                errorResponse.ErrorString = await response.Content.ReadAsStringAsync();
                errorResponse.ErrorCode = response.StatusCode.ToString();
                return errorResponse;
            }
        }
    }
}
