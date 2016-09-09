using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models
{
    public class PropertyRichList
    {
        [JsonProperty("area_name")]
        public string AreaName { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        [JsonProperty("richlist_url")]
        public string RichlistUrl { get; set; }
        public List<RichListObject> Highest { get; set; }
        public List<RichListObject> Lowest { get; set; }
    }
}
