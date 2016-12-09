using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoopla.Net.Models.AverageSoldPrices;

namespace Zoopla.Net.Models.AverageAreaSoldPrices
{
    public class AverageAreaSoldPriceResponse : AverageSoldPriceResponse
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
