using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models
{
    public class ResponseModelBase
    {
        [JsonProperty("area_name")]
        public string AreaName { get; set; }

        public string Street { get; set; }

        public string Town { get; set; }

        public string Postcode { get; set; }

        public string County { get; set; }

        public string Country { get; set; }

        [JsonProperty("bounding_box")]
        public BoundingBox BoundingBox { get; set; }

        [JsonProperty("error_string")]
        public string ErrorString { get; set; }

        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }
    }
}
