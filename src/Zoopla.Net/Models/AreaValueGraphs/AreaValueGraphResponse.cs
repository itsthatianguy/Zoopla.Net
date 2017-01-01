using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models
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
