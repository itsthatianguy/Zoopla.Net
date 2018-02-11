using System.Threading.Tasks;
using Zoopla.Net.Core.Models.AreaValueGraphs;
using Zoopla.Net.Core.Models.ArrangeViewing;
using Zoopla.Net.Core.Models.AverageAreaSoldPrices;
using Zoopla.Net.Core.Models.AverageSoldPrices;
using Zoopla.Net.Core.Models.GeoAutocomplete;
using Zoopla.Net.Core.Models.Listings;
using Zoopla.Net.Core.Models.LocalInfoGraphs;
using Zoopla.Net.Core.Models.PropertyRichList;
using Zoopla.Net.Core.Models.RefineEstimate;
using Zoopla.Net.Core.Models.Session;
using Zoopla.Net.Core.Models.ZedIndex;
using Zoopla.Net.Core.Models.ZedIndices;
using Zoopla.Net.Core.Options;
using Zoopla.Net.Core.Options.AreaValueGraphs;
using Zoopla.Net.Core.Options.ArrangeViewing;
using Zoopla.Net.Core.Options.AverageSoldPrices;
using Zoopla.Net.Core.Options.GeoAutocomplete;
using Zoopla.Net.Core.Options.Listings;
using Zoopla.Net.Core.Options.RefineEstimate;
using Zoopla.Net.Core.Options.ZedIndices;

namespace Zoopla.Net.Core
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
        Task<PropertyListingsResponse> GetPropertyListings(StandardLocationParameters locationParams, ListingBaseOptions options);
        Task<PropertyRichListResponse> GetPropertyRichList(StandardLocationParameters locationParams);
        Task<RefineEstimateResponse> GetRefineEstimate(RefineEstimateOptions options);
        Task<SessionResponse> GetSessionId();
        Task<ZedIndexResponse> GetZedIndex(StandardLocationParameters locationParams);
    }
}