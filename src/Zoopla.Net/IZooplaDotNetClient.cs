using System.Threading.Tasks;
using Zoopla.Net.Models;
using Zoopla.Net.Options;

namespace Zoopla.Net
{
    public interface IZooplaDotNetClient
    {
        Task<ArrangeViewingResponse> ArrangeViewing(ArrangeViewingOptions options);
        Task<AreaValueGraphResponse> GetAreaValueGraphs(StandardLocationParameters locationParams, AreaValueGraphOptions options);
        Task<ZedIndicesResponse> GetAreaZedIndices(StandardLocationParameters locationParams, ZedIndicesOptions options);
        Task<AverageAreaSoldPriceResponse> GetAverageAreaSoldPrice(StandardLocationParameters locationParams);
        Task<AverageSoldPriceResponse> GetAverageSoldPrices(StandardLocationParameters locationParams, AverageSoldPricesOptions options);
        Task<GeoAutocompleteResponse> GetGeoAutocomplete(GeoAutocompleteOptions options);
        Task<LocalInfoGraphResponse> GetLocalInfoGraphs(StandardLocationParameters locationParams);
        Task<PropertyListingsResponse> GetPropertyListingsByIds(ListingBaseOptions options);
        Task<PropertyListingsResponse> GetPropertyListings(StandardLocationParameters locationParams, ListingBaseOptions options);
        Task<PropertyRichListResponse> GetPropertyRichList(StandardLocationParameters locationParams);
        Task<RefineEstimateResponse> GetRefineEstimate(RefineEstimateOptions options);
        Task<SessionResponse> GetSessionId();
        Task<ZedIndexResponse> GetZedIndex(StandardLocationParameters locationParams);
    }
}