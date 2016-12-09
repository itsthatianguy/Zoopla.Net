using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models.Listings
{
    public class PropertyListings
    {
        [JsonProperty("result_count")]
        public int ResultCount { get; set; }
        public double Longitude { get; set; }
        [JsonProperty("listing")]
        public List<Listing> Listings { get; set; }
        public double Latitude { get; set; }
    }
}
