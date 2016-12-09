using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models.PropertyRichList
{
    public class PropertyRichListResponse : ResponseModelBase
    {
        [JsonProperty("richlist_url")]
        public string RichlistUrl { get; set; }
        public List<RichListDetails> Highest { get; set; }
        public List<RichListDetails> Lowest { get; set; }
    }
}
