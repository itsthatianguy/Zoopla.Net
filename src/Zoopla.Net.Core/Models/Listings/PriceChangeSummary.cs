using System;
using Newtonsoft.Json;

namespace Zoopla.Net.Core.Models.Listings
{
    public class PriceChangeSummary
    {
        public string Direction { get; set; }
        public string Percent { get; set; }
        [JsonProperty("last_updated_date")]
        public DateTime LastUpdatedDate { get; set; }
    }
}
