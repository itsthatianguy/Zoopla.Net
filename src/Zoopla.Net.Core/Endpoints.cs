namespace Zoopla.Net.Core
{
    public class Endpoints
    {
        public static readonly string ROOT_API = @"https://api.zoopla.co.uk/api/v1/";
        public static readonly string PROPERTY_LISTINGS = ROOT_API + @"property_listings.json";
        public static readonly string AVERAGE_SOLD_PRICES = ROOT_API + @"average_sold_prices.json";
        public static readonly string PROPERTY_RICH_LIST = ROOT_API + @"richlist.json";
        public static readonly string AVERAGE_AREA_SOLD_PRICE = ROOT_API + @"average_area_sold_price.json";
        public static readonly string ZED_INDEX = ROOT_API + @"zed_index.json";
        public static readonly string ZED_INDICES = ROOT_API + @"zed_indices.json";
        public static readonly string AREA_VALUE_GRAPHS = ROOT_API + @"area_value_graphs.json";
        public static readonly string SESSION_ID = ROOT_API + @"get_session_id.json";
        public static readonly string REFINE_ESTIMATE = ROOT_API + @"refine_estimate.json";
        public static readonly string ARRANGE_VIEWING = ROOT_API + @"arrange_viewing.json";
        public static readonly string LOCAL_INFO_GRAPHS = ROOT_API + @"local_info_graphs.json";
        public static readonly string GEO_AUTOCOMPLETE = ROOT_API + @"geo_autocomplete.json";

        // The provision of Zoopla Estimate data is available to 3rd party developers but is on an individual request basis only and depending on usage volumes may incur a charge.

        // Allows developers to build their own Appraisal engine like the one on Zoopla by making three separate API calls to find a property and contact the agent for a valuation.

        // The provision of Historic Listings data is available to 3rd party developers but is on an individual request basis only and depending on usage volumes may incur a charge.
    }
}
