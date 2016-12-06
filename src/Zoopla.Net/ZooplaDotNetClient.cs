using System;
using System.Threading.Tasks;
using Zoopla.Net.Models;
using Zoopla.Net.Options;
using Zoopla.Net.Options.AreaValueGraphs;
using Zoopla.Net.Options.ArrangeViewing;
using Zoopla.Net.Options.AverageSoldPrices;
using Zoopla.Net.Options.PropertyRichList;
using Zoopla.Net.Options.ZedIndices;

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

        public Task<PropertyListings> GetPropertyListings(StandardLocationParameters locationParams, ListingBaseOptions options)
        {
            string url = Endpoints.PROPERTY_LISTINGS + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();
            url += options.GetUrlParams();

            return _httpClient.GetObject<PropertyListings>(url);
        }

        public Task<AverageSoldPrice> GetAverageSoldPrices(StandardLocationParameters locationParams, AverageSoldPricesOptions options)
        {
            string url = Endpoints.AVERAGE_SOLD_PRICES + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();
            url += options.GetUrlParams();

            return _httpClient.GetObject<AverageSoldPrice>(url);
        }

        public Task<PropertyRichList> GetPropertyRichList(StandardLocationParameters locationParams)
        {
            string url = Endpoints.PROPERTY_RICH_LIST + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();

            return _httpClient.GetObject<PropertyRichList>(url);
        }

        public Task<AverageAreaSoldPrice> GetAverageAreaSoldPrice(StandardLocationParameters locationParams)
        {
            string url = Endpoints.AVERAGE_AREA_SOLD_PRICE + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();

            return _httpClient.GetObject<AverageAreaSoldPrice>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options">OutputType on options can only be TOWN, OUTCODE, COUNTY, or COUNTRY</param>
        /// <returns></returns>
        public Task<ZedIndexObject> GetZedIndex(StandardAreaOptions options)
        {
            string url = Endpoints.ZED_INDEX + "?api_key=" + _accessToken;

            url += options.GetUrlParams();

            return _httpClient.GetObject<ZedIndexObject>(url);
        }

        public Task<ZedIndices> GetZedIndices(ZedIndicesOptions options)
        {
            string url = Endpoints.ZED_INDICES + "?api_key=" + _accessToken;

            url += options.GetUrlString();

            return _httpClient.GetObject<ZedIndices>(url);
        }

        public Task<AreaValueGraph> GetAreaValueGraphs(StandardLocationParameters locationParams, AreaValueGraphOptions options)
        {
            string url = Endpoints.AREA_VALUE_GRAPHS + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();
            url += options.GetUrlParams();

            return _httpClient.GetObject<AreaValueGraph>(url);
        }

        public Task<Session> GetSessionId()
        {
            string url = Endpoints.SESSION_ID + "?api_key=" + _accessToken;

            return _httpClient.GetObject<Session>(url);
        }

        //public Task<string> GetRefineEstimate()
        //{
        //    string url = Endpoints.REFINE_ESTIMATE + "?api_key=" + _accessToken;

        //    throw new NotImplementedException();
        //}

        public Task<ArrangeViewing> ArrangeViewing(ArrangeViewingOptions options)
        {
            string url = Endpoints.ARRANGE_VIEWING + "?api_key=" + _accessToken;

            url += options.GetUrlString();

            return _httpClient.GetObject<ArrangeViewing>(url);
        }

        //public Task<LocalInfoGraphs> GetLocalInfoGraphs(StandardAreaOptions options)
        //{
        //    string url = Endpoints.LOCAL_INFO_GRAPHS + "?api_key=" + _accessToken;

        //    url += options.GetUrlString();

        //    return _httpClient.GetObject<LocalInfoGraphs>(url);
        //}

        //public Task<string> GetGeoAutocomplete()
        //{
        //    string url = Endpoints.GEO_AUTOCOMPLETE + "?api_key=" + _accessToken;

        //    throw new NotImplementedException();
        //}
    }
}
