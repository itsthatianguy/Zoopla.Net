using System;
using System.Threading.Tasks;
using Zoopla.Net.Models;
using Zoopla.Net.Options;

namespace Zoopla.Net
{
    public class ZooplaDotNetClient
    {
        private string _accessToken = String.Empty;
        private ZooplaHttpClient _httpClient;

        public ZooplaDotNetClient(string token)
        {
            _accessToken = token;
            _httpClient = new ZooplaHttpClient();
        }

        public async Task<PropertyListings> GetPropertyListings(ListingBaseOptions options)
        {
            string url = Endpoints.PROPERTY_LISTINGS + "?api_key=" + _accessToken;

            url += options.GetUrlString();

            return await _httpClient.GetObject<PropertyListings>(url);
        }

        public async Task<AverageSoldPrices> GetAverageSoldPrices(string postcode, OutputType outputType, AreaType areaType)
        {
            string url = Endpoints.AVERAGE_SOLD_PRICES + "?api_key=" + _accessToken;

            // As above for this one too

            // Best way to append options?
            url += "&postcode=" + postcode;
            url += "&output_type=" + outputType.ToString().ToLower();
            url += "&area_type=" + areaType.ToString().ToLower();

            return await _httpClient.GetObject<AverageSoldPrices>(url);
        }
    }
}
