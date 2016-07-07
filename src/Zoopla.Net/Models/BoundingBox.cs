using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models
{
    public class BoundingBox
    {
        [JsonProperty("longitude_min")]
        public string LongitudeMin { get; set; }
        [JsonProperty("latitude_min")]
        public string LatitudeMin { get; set; }
        [JsonProperty("longitude_max")]
        public string LongitudeMax { get; set; }
        [JsonProperty("latitude_max")]
        public string LatitudeMax { get; set; }
    }
}
