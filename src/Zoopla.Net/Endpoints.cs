using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net
{
    public class Endpoints
    {
        public static readonly string ROOT_API = @"http://api.zoopla.co.uk/api/v1/";
        public static readonly string PROPERTY_LISTINGS = ROOT_API + @"property_listings.json";
        public static readonly string AVERAGE_SOLD_PRICES = ROOT_API + @"average_sold_prices.json";
    }
}
