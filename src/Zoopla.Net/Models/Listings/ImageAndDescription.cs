using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Zoopla.Net.Models.Listings
{
    public class ImageAndDescription
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
