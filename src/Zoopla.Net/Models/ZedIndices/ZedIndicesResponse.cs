using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoopla.Net.Models.ZedIndices;

namespace Zoopla.Net.Models
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
