using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models.Listings
{
    public class PriceChangeSummary
    {
        public string Direction { get; set; }
        public string Percent { get; set; }
        [JsonProperty("last_updated_date")]
        public string LastUpdatedDate { get; set; }
    }
}
