using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Zoopla.Net.Options.Enums;

namespace Zoopla.Net.Options.AverageSoldPrices
{
    public class AverageSoldPricesOptions : OptionsBase
    {
        public AverageSoldPricesOptions()
        {
            PageSize = 10;
            PageNumber = 1;
            Ordering = Ordering.DESCENDING;
        }

        public int PageSize
        {
            set
            {
                UrlValues["page_size"] = value.ToString();
            }
        }
        public int PageNumber
        {
            set
            {
                UrlValues["page_number"] = value.ToString();
            }
        }
        public Ordering Ordering
        {
            set
            {
                UrlValues["ordering"] = value.ToString()?.ToLower();
            }
        }

    }
}
