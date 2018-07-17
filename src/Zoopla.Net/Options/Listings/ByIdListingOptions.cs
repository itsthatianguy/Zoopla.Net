using System;

namespace Zoopla.Net.Options
{
    public class ByIdListingOptions : ListingBaseOptions
    {
        /// <summary>
        /// Options for searching for property by an ID or IDs
        /// </summary>
        /// <param name="id">An ID or a comma separated list of IDs</param>
        public ByIdListingOptions(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException(nameof(id));

            ListingId = id;
            IncludeSoldAndRented = false;
        }

        /// <summary>
        /// You can include sold and rented properties. By default these are excluded
        /// </summary>
        public bool IncludeSoldAndRented
        {
            set
            {
                UrlValues["include_sold"] = value ? "1" : "0";
                UrlValues["include_rented"] = value ? "1" : "0";
            }
        }
    }
}