using Newtonsoft.Json;

namespace Zoopla.Net.Core.Models.AreaValueGraphs
{
    public class AreaValueGraphResponse : ResponseModelBase
    {
        [JsonProperty("area_values_url")]
        public string AreaValuesUrl { get; set; }
        [JsonProperty("home_values_graph_url")]
        public string HomeValuesGraphUrl { get; set; }
        [JsonProperty("value_trend_graph_url")]
        public string ValueTrendGraphUrl { get; set; }
        [JsonProperty("value_ranges_graph_url")]
        public string ValueRangesGraphUrl { get; set; }
        [JsonProperty("average_values_graph_url")]
        public string AverageValuesGraphUrl { get; set; }
    }
}
