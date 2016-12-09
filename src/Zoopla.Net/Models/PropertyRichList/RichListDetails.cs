using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models.PropertyRichList
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
