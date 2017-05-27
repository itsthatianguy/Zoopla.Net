using System;
using System.Threading.Tasks;
using Zoopla.Net.Models;
using Zoopla.Net.Options;

namespace Zoopla.Net
{
    public class ZooplaDotNetClient : IZooplaDotNetClient
    {
        private string _accessToken = String.Empty;
        private ZooplaHttpClient _httpClient;

        public ZooplaDotNetClient(string token)
        {
            _accessToken = token;
            _httpClient = new ZooplaHttpClient();
        }

        /// <summary>
        /// Gets listings of properties either for sale or rent, depending on the supplied options.
        /// </summary>
        /// <param name="locationParams">The standard location parameters.</param>
        /// <param name="options">The rental or sales listing options.</param>
        /// <returns>A list of properties matching the given criteria.</returns>
        public Task<PropertyListingsResponse> GetPropertyListings(StandardLocationParameters locationParams, ListingBaseOptions options)
        {
            string url = Endpoints.PROPERTY_LISTINGS + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();
            url += options.GetUrlParams();

            return _httpClient.GetObject<PropertyListingsResponse>(url);
        }

        /// <summary>
        /// Gets the average sold prices for a particular sub-area type.
        /// </summary>
        /// <param name="locationParams">The standard location parameters.</param>
        /// <param name="options">The paging and ordering options.</param>
        /// <returns>A list of average sold prices for each given sub-area type in the area.</returns>
        public Task<AverageSoldPriceResponse> GetAverageSoldPrices(StandardLocationParameters locationParams, AverageSoldPricesOptions options)
        {
            string url = Endpoints.AVERAGE_SOLD_PRICES + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();
            url += options.GetUrlParams();

            return _httpClient.GetObject<AverageSoldPriceResponse>(url);
        }

        /// <summary>
        /// Gets the property rich list values for a particular area.
        /// </summary>
        /// <param name="locationParams">The standard location parameters.</param>
        /// <returns>A list of the highest and lowest average Zed-Index estimates for sub-areas within the area.</returns>
        public Task<PropertyRichListResponse> GetPropertyRichList(StandardLocationParameters locationParams)
        {
            string url = Endpoints.PROPERTY_RICH_LIST + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();

            return _httpClient.GetObject<PropertyRichListResponse>(url);
        }

        /// <summary>
        /// Gets the average sold prices for an area.
        /// </summary>
        /// <param name="locationParams">The standard location parameters.</param>
        /// <returns>The number of sales, and average sold prices, for the area within the last 1, 3, 5 and 7 years.</returns>
        public Task<AverageAreaSoldPriceResponse> GetAverageAreaSoldPrice(StandardLocationParameters locationParams)
        {
            string url = Endpoints.AVERAGE_AREA_SOLD_PRICE + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();

            return _httpClient.GetObject<AverageAreaSoldPriceResponse>(url);
        }

        /// <summary>
        /// Gets the Zoopla Zed-Index for an area.
        /// </summary>
        /// <param name="options">
        /// The standard location parameters.
        /// OutputType for this endpoint can only be TOWN, OUTCODE, COUNTY, or COUNTRY
        /// </param>
        /// <returns>The Zed Indexes for the last 5 years for the given area.</returns>
        public Task<ZedIndexResponse> GetZedIndex(StandardLocationParameters locationParams)
        {
            string url = Endpoints.ZED_INDEX + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();

            return _httpClient.GetObject<ZedIndexResponse>(url);
        }

        /// <summary>
        /// Gets a list of house price estimates for the requested area.
        /// </summary>
        /// <param name="locationParams">The standard location parameters.</param>
        /// <param name="options">The options.</param>
        /// <returns>A list of results containing the Zed-Index value, and the Latitude, Longitude and Name of the result.</returns>
        public Task<ZedIndicesResponse> GetAreaZedIndices(StandardLocationParameters locationParams, ZedIndicesOptions options)
        {
            string url = Endpoints.ZED_INDICES + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();
            url += options.GetUrlParams();

            return _httpClient.GetObject<ZedIndicesResponse>(url);
        }

        /// <summary>
        /// Generates a graph of values for an outcode over the previous 3 months and return the URL to the generated image.
        /// </summary>
        /// <param name="locationParams">
        /// The standard location parameters.
        /// OutputType must be OUTCODE.
        /// </param>
        /// <param name="options">The size option for the graph.</param>
        /// <returns>URLs for Home Values, Value Trend, Value Ranges, and Average Values graphs.</returns>
        public Task<AreaValueGraphResponse> GetAreaValueGraphs(StandardLocationParameters locationParams, AreaValueGraphOptions options)
        {
            string url = Endpoints.AREA_VALUE_GRAPHS + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();
            url += options.GetUrlParams();

            return _httpClient.GetObject<AreaValueGraphResponse>(url);
        }

        /// <summary>
        /// Gets the session identifier.
        /// </summary>
        /// <returns></returns>
        public Task<SessionResponse> GetSessionId()
        {
            string url = Endpoints.SESSION_ID + "?api_key=" + _accessToken;

            return _httpClient.GetObject<SessionResponse>(url);
        }

        /// <summary>
        /// Gets a more accurate Zoopla Zed-Index based on extra data provided.
        /// </summary>
        /// <param name="options">Extended property information.</param>
        /// <returns>Value estimates and confidence rating of that estimate.</returns>
        public Task<RefineEstimateResponse> GetRefineEstimate(RefineEstimateOptions options)
        {
            string url = Endpoints.REFINE_ESTIMATE + "?api_key=" + _accessToken;

            url += options.GetUrlParams();

            return _httpClient.GetObject<RefineEstimateResponse>(url);
        }

        /// <summary>
        /// Submit a viewing request to an agent regarding a particular listing.
        /// </summary>
        /// <param name="options">Details of the property, and the individual requesting the viewing.</param>
        /// <returns>Success code of 1 or 0. If 0, an error string is populated.</returns>
        public Task<ArrangeViewingResponse> ArrangeViewing(ArrangeViewingOptions options)
        {
            string url = Endpoints.ARRANGE_VIEWING + "?api_key=" + _accessToken;

            url += options.GetUrlParams();

            return _httpClient.GetObject<ArrangeViewingResponse>(url);
        }

        /// <summary>
        /// Generate a set of graphs of local info for an outcode and return the URL to the generated image.
        /// </summary>
        /// <param name="locationParams">The standard location parameters.</param>
        /// <returns>URLs of info graphs for the area for crime, education, people, and council tax.</returns>
        public Task<LocalInfoGraphResponse> GetLocalInfoGraphs(StandardLocationParameters locationParams)
        {
            string url = Endpoints.LOCAL_INFO_GRAPHS + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();

            return _httpClient.GetObject<LocalInfoGraphResponse>(url);
        }

        /// <summary>
        /// Gets the auto suggestion for locations.
        /// </summary>
        /// <param name="options">The type of search being performed, and the term to search with.</param>
        /// <returns>A list of suggested values if a match is found.</returns>
        public Task<GeoAutocompleteResponse> GetGeoAutocomplete(GeoAutocompleteOptions options)
        {
            string url = Endpoints.GEO_AUTOCOMPLETE + "?api_key=" + _accessToken;

            url += options.GetUrlParams();

            return _httpClient.GetObject<GeoAutocompleteResponse>(url);
        }
    }
}
