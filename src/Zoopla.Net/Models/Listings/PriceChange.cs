using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models.Listings
{
    public class PriceChange
    {
        public string Direction { get; set; }
        public string Date { get; set; }
        public string Percent { get; set; }
        public string Price { get; set; }
    }
}
