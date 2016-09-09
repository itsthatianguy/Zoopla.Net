using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models
{
    public class ZedIndexObject
    {
        [JsonProperty("area_url")]
        public string AreaUrl { get; set; }
        [JsonProperty("zed_index")]
        public string ZedIndex { get; set; }
        [JsonProperty("zed_index_3month")]
        public string ZedIndex3Month { get; set; }
        [JsonProperty("zed_index_6month")]
        public string ZedIndex6Month { get; set; }
        [JsonProperty("zed_index_1year")]
        public string ZedIndex1Year { get; set; }
        [JsonProperty("zed_index_2year")]
        public string ZedIndex2Year { get; set; }
        [JsonProperty("zed_index_3year")]
        public string ZedIndex3Year { get; set; }
        [JsonProperty("zed_index_4year")]
        public string ZedIndex4Year { get; set; }
        [JsonProperty("zed_index_5year")]
        public string ZedIndex5Year { get; set; }
    }
}
