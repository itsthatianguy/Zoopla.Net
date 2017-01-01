using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoopla.Net.Models.GeoAutocomplete;

namespace Zoopla.Net.Options
{
    public class GeoAutocompleteOptions : OptionsBase
    {
        public string SearchTerm
        {
            set
            {
                UrlValues["search_term"] = value;
            }
        }

        public SearchType SearchType
        {
            set
            {
                UrlValues["search_type"] = value.ToString()?.ToLower();
            }
        }
    }
}
