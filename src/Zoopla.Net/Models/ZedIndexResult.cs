using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models
{
    public class ZedIndexResult
    {
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        [JsonProperty("zed_index")]
        public string ZedIndex { get; set; }
    }
}
