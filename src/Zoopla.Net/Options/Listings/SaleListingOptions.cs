using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Options
{
    public class SaleListingOptions : ListingBaseOptions
    {
        public SaleListingOptions()
        {
            IncludeSold = 0;
            UrlValues["listing_status"] = "sale";
        }

        /// <summary>
        /// Value is either 0 (false) or 1 (true)
        /// </summary>
        public int IncludeSold
        {
            set
            {
                UrlValues["include_sold"] = value.ToString();
            }
        }
        public bool NewHomes
        {
            set
            {
                UrlValues["new_homes"] = value.ToString();
            }
        }
        public bool ChainFree
        {
            set
            {
                UrlValues["chain_free"] = value.ToString();
            }
        }
    }
}
