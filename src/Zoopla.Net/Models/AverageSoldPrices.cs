using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models
{
    public class AverageSoldPrices
    {
        public string Country { get; set; }
        [JsonProperty("result_count")]
        public string ResultCount { get; set; }
        public double Longitude { get; set; }
        [JsonProperty("area_name")]
        public string AreaName { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public double Latitude { get; set; }
        public string County { get; set; }
        public List<Area> Areas { get; set; }
        [JsonProperty("bounding_box")]
        public BoundingBox BoundingBox { get; set; }
        public string Postcode { get; set; }
    }
}
