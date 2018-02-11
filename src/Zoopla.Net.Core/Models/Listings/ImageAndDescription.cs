using Newtonsoft.Json;

namespace Zoopla.Net.Core.Models.Listings
{
    public class ImageAndDescription
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
