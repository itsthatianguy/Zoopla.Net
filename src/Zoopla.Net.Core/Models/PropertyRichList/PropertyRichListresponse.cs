using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zoopla.Net.Core.Models.PropertyRichList
{
    public class PropertyRichListResponse : ResponseModelBase
    {
        [JsonProperty("richlist_url")]
        public string RichlistUrl { get; set; }
        public List<RichListDetails> Highest { get; set; }
        public List<RichListDetails> Lowest { get; set; }
    }
}
