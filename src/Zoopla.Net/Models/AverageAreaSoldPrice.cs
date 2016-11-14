using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models
{
    public class AverageAreaSoldPrice : AverageSoldPrice
    {
        public string Country { get; set; }
        public string County { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        [JsonProperty("bounding_box")]
        public BoundingBox BoundingBox { get; set; }
        public string Postcode { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
    }
}
