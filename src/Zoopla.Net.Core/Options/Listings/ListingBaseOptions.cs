using System;
using System.Text.RegularExpressions;
using Zoopla.Net.Core.Options.Enums;

namespace Zoopla.Net.Core.Options.Listings
{
    public abstract class ListingBaseOptions : OptionsBase
    {
        /// <summary>
        /// Radius range is from 0.1 to 40. Setting this property will take the lowest number between 40 and the provided value.
        /// </summary>
        public float Radius
        {
            set => UrlValues["radius"] = Math.Min(value, 40).ToString();
        } 
        public OrderBy OrderBy
        {
            set => UrlValues["order_by"] = value.ToString()?.ToLower();
        }
        public Ordering Ordering
        {
            set => UrlValues["ordering"] = value.ToString()?.ToLower();
        }
        public int MinimumPrice
        {
            set => UrlValues["minimum_price"] = value.ToString();
        }
        public int MaximumPrice
        {
            set => UrlValues["maximum_price"] = value.ToString();
        }
        public int MinimumBeds
        {
            set => UrlValues["minimum_beds"] = value.ToString();
        }
        public int MaximumBeds
        {
            set => UrlValues["maximum_beds"] = value.ToString();
        }
        public PropertyType PropertyType
        {
            set => UrlValues["property_type"] = value.ToString()?.ToLower();
        }
        /// <summary>
        /// Setting the Keywords property will use a regular expression to make the text URL friendly for the Zoopla API
        /// </summary>
        public string Keywords
        {
            set => UrlValues["keywords"] = Regex.Replace(value, @"[^A-Za-z0-9_\.~]+", "+");
        }
        public string ListingId
        {
            set => UrlValues["listing_id"] = value;
        }
        public string BranchId
        {
            set => UrlValues["branch_id"] = value;
        }
        public int PageNumber
        {
            set => UrlValues["page_number"] = value.ToString();
        }
        public int PageSize
        {
            set => UrlValues["page_size"] = value.ToString();
        }
        public bool Summarized
        {
            set => UrlValues["summarized"] = value.ToString();
        }
    }
}
