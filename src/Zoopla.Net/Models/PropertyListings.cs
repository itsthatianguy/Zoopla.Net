using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models
{
    public class PropertyListings
    {
        public string Country { get; set; }
        [JsonProperty("result_count")]
        public int ResultCount { get; set; }
        public double Longitude { get; set; }
        [JsonProperty("area_name")]
        public string AreaName { get; set; }
        [JsonProperty("listing")]
        public List<Listing> Listings { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public double Latitude { get; set; }
        public string County { get; set; }
        [JsonProperty("bounding_box")]
        public BoundingBox BoundingBox { get; set; }
        public string Postcode { get; set; }
    }
}
