using System.Collections.Generic;
using Zoopla.Net.Options.Enums;

namespace Zoopla.Net.Options
{
    public class RentListingOptions : ListingBaseOptions
    {
        public int? IncludeRented { get; set; } // Either 1 or 0
        public Furnished Furnished { get; set; }

        public override string GetUrlString()
        {
            UrlValues = new Dictionary<string, string>();
            // Add all values to the dictionary - separate into a construct method?
            // Then add as appropriate to the url string

            // Call base construct method first to add common properties to dictionary
            AddCommonProperties();

            AddRentalOptions();

            return ConstructUrl();
        }

        private void AddRentalOptions()
        {
            UrlValues.Add("include_rented", IncludeRented.ToString()?.ToLower());
            UrlValues.Add("furnished", Furnished.ToString()?.ToLower());
        }
    }
}
