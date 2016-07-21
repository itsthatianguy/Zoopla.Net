using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Options
{
    public class SaleListingOptions : ListingBaseOptions
    {
        public int? IncludeSold { get; set; } // Either 1 or 0
        public bool? NewHomes { get; set; }
        public bool? ChainFree { get; set; }


        public override string GetUrlString()
        {
            // If we're getting the URL string, clear any existing set values so it's accurate
            UrlValues = new Dictionary<string, string>();
            // Add the properties shared between rental and sales listings
            AddCommonProperties();
            // Add the sales specific properties
            AddSalesOptions();
            // Return the output of constructing the URL on the base class
            return ConstructUrl();
        }

        private void AddSalesOptions()
        {
            UrlValues.Add("include_sold", IncludeSold.ToString()?.ToLower());
            UrlValues.Add("new_homes", NewHomes.ToString()?.ToLower());
            UrlValues.Add("chain_free", ChainFree.ToString()?.ToLower());
        }
    }
}
