using Newtonsoft.Json;

namespace Zoopla.Net.Core.Models.PropertyRichList
{
    public class RichListDetails
    {
        public string Name { get; set; }
        [JsonProperty("zed_index")]
        public string ZedIndex { get; set; }
        [JsonProperty("details_url")]
        public string DetailsUrl { get; set; }
    }
}
