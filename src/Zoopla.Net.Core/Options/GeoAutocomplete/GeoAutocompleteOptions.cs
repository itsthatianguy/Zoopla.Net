using Zoopla.Net.Core.Models.GeoAutocomplete;

namespace Zoopla.Net.Core.Options.GeoAutocomplete
{
    public class GeoAutocompleteOptions : OptionsBase
    {
        public string SearchTerm
        {
            set => UrlValues["search_term"] = value;
        }

        public SearchType SearchType
        {
            set => UrlValues["search_type"] = value.ToString()?.ToLower();
        }
    }
}
