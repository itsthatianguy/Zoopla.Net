using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models
{
    public class ZedIndices
    {
        [JsonProperty("area_name")]
        public string AreaName { get; set; }
        [JsonProperty("results_url")]
        public string ResultsUrl { get; set; }
        [JsonProperty("result_count")]
        public string ResultCount { get; set; }
        public List<ZedIndexResult> Results { get; set; }
        [JsonProperty("bounding_box")]
        public BoundingBox BoundingBox { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Postcode { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
    }
}
