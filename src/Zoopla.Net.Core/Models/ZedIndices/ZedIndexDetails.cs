using Newtonsoft.Json;

namespace Zoopla.Net.Core.Models.ZedIndices
{
    public class ZedIndexDetails
    {
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        [JsonProperty("zed_index")]
        public string ZedIndex { get; set; }
    }
}
