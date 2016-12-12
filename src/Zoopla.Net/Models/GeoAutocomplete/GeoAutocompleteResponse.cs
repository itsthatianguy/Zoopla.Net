using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models.GeoAutocomplete
{
    public class GeoAutocompleteResponse : ResponseModelBase
    {
        public List<Suggestion> Suggestions { get; set; }
    }
}
