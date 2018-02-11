using System.Collections.Generic;

namespace Zoopla.Net.Core.Models.GeoAutocomplete
{
    public class GeoAutocompleteResponse : ResponseModelBase
    {
        public List<Suggestion> Suggestions { get; set; }
    }
}
