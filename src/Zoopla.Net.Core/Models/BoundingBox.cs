using Newtonsoft.Json;

namespace Zoopla.Net.Core.Models
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
