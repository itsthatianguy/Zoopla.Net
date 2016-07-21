using System;
using System.Threading.Tasks;
using Zoopla.Net.Models;
using Zoopla.Net.Options;
using Zoopla.Net.Options.AverageSoldPrices;

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

        public async Task<AverageSoldPrices> GetAverageSoldPrices(AverageSoldPricesOptions options)
        {
            string url = Endpoints.AVERAGE_SOLD_PRICES + "?api_key=" + _accessToken;

            url += options.GetUrlString();

            return await _httpClient.GetObject<AverageSoldPrices>(url);
        }

        public async Task<string> GetPropertyRichList()
        {
            string url = Endpoints.PROPERTY_RICH_LIST + "?api_key=" + _accessToken;

            throw new NotImplementedException();
        }

        public async Task<string> GetAverageAreaSoldPrice()
        {
            string url = Endpoints.AVERAGE_AREA_SOLD_PRICE + "?api_key=" + _accessToken;

            throw new NotImplementedException();
        }

        public async Task<string> GetZedIndex()
        {
            string url = Endpoints.ZED_INDEX + "?api_key=" + _accessToken;

            throw new NotImplementedException();
        }

        public async Task<string> GetZedIndices()
        {
            string url = Endpoints.ZED_INDICES + "?api_key=" + _accessToken;

            throw new NotImplementedException();
        }

        public async Task<string> GetAreaValueGraphs()
        {
            string url = Endpoints.AREA_VALUE_GRAPHS + "?api_key=" + _accessToken;

            throw new NotImplementedException();
        }

        public async Task<string> GetSessionId()
        {
            string url = Endpoints.SESSION_ID + "?api_key=" + _accessToken;

            throw new NotImplementedException();
        }

        public async Task<string> GetRefineEstimate()
        {
            string url = Endpoints.REFINE_ESTIMATE + "?api_key=" + _accessToken;

            throw new NotImplementedException();
        }

        public async Task<string> ArrangeViewing()
        {
            string url = Endpoints.ARRANGE_VIEWING + "?api_key=" + _accessToken;

            throw new NotImplementedException();
        }

        public async Task<string> GetLocalInfoGraphs()
        {
            string url = Endpoints.LOCAL_INFO_GRAPHS + "?api_key=" + _accessToken;

            throw new NotImplementedException();
        }

        public async Task<string> GetGeoAutocomplete()
        {
            string url = Endpoints.GEO_AUTOCOMPLETE + "?api_key=" + _accessToken;

            throw new NotImplementedException();
        }
    }
}
