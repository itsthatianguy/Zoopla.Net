using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zoopla.Net.Core.Models.ZedIndices
{
    public class ZedIndicesResponse : ResponseModelBase
    {
        [JsonProperty("results_url")]
        public string ResultsUrl { get; set; }
        [JsonProperty("result_count")]
        public string ResultCount { get; set; }
        public List<ZedIndexDetails> Results { get; set; }
    }
}
