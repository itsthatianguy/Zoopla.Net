using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Zoopla.Net.Options.Enums;

namespace Zoopla.Net.Options
{
    public abstract class ListingBaseOptions
    {
        protected float? _radius;
        protected string _keywords;
        protected string _postcode;

        internal string Url;
        internal Dictionary<string, string> UrlValues { get; set; }

        /// <summary>
        /// Area takes precendence over PostCode when using the Zoopla API
        /// </summary>
        public string Area { get; set; }
        public string PostCode
        {
            get
            {
                return _postcode;
            }
            set
            {
                // Remove spaces from the postcode
                _postcode = Regex.Replace(value, @"\s+", "");
            }
        }
        /// <summary>
        /// Radius range is from 0.1 to 40. Setting this property will take the lowest number between 40 and the provided value.
        /// Nulling the value will have no effect
        /// </summary>
        public float? Radius {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value != null ? Math.Min(value.Value, 40) : _radius;
            } 
        } 
        public OrderBy OrderBy { get; set; }
        public Ordering Ordering { get; set; }
        public int? MinimumPrice { get; set; }
        public int? MaximumPrice { get; set; }
        public int? MinimumBeds { get; set; }
        public int? MaximumBeds { get; set; }
        public PropertyType PropertyType { get; set; }
        /// <summary>
        /// Setting the Keywords property will use a regular expression to make the text URL friendly for the Zoopla API
        /// </summary>
        public string Keywords
        {
            get
            {
                return _keywords;
            }
            set
            {
                _keywords = Regex.Replace(value, @"[^A-Za-z0-9_\.~]+", "+"); ;
            }
        }
        public string ListingId { get; set; }
        public string BranchId { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
        public bool? Summarized { get; set; }

        public abstract string GetUrlString();

        // TODO: Rename
        internal void AddCommonProperties()
        {
            UrlValues.Add("area", Area?.ToLower());
            UrlValues.Add("postcode", PostCode?.ToLower());
            UrlValues.Add("radius", Radius.ToString()?.ToLower());
            UrlValues.Add("order_by", OrderBy.ToString()?.ToLower());
            UrlValues.Add("ordering", Ordering.ToString()?.ToLower());
            UrlValues.Add("minimum_price", MinimumPrice.ToString()?.ToLower());
            UrlValues.Add("maximum_price", MaximumPrice.ToString()?.ToLower());
            UrlValues.Add("minimum_beds", MinimumBeds.ToString()?.ToLower());
            UrlValues.Add("maximum_beds", MaximumBeds.ToString()?.ToLower());
            UrlValues.Add("property_type", PropertyType.ToString()?.ToLower());
            UrlValues.Add("keywords", Keywords?.ToLower());
            UrlValues.Add("listing_id", ListingId?.ToLower());
            UrlValues.Add("branch_id", BranchId?.ToLower());
            UrlValues.Add("page_number", PageNumber.ToString()?.ToLower());
            UrlValues.Add("page_size", PageSize.ToString()?.ToLower());
            UrlValues.Add("summarized", Summarized.ToString()?.ToLower());
        }

        internal string ConstructUrl()
        {
            // Construct url from dictionary
            foreach (KeyValuePair<string, string> keyValue in UrlValues)
            {
                // Some values can be 0...
                if (keyValue.Value != String.Empty &&
                    keyValue.Value != null &&
                    keyValue.Value != "0")
                {
                    Url += "&" + keyValue.Key + "=" + keyValue.Value;
                }
            }

            return Url;
        }
    }
}
