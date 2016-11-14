using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models
{
    public class Session
    {
        [JsonProperty("area_name")]
        public string AreaName { get; set; }
        [JsonProperty("session_id")]
        public string SessionId { get; set; }
        public string Street { get; set; }
        public string County { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
    }
}
