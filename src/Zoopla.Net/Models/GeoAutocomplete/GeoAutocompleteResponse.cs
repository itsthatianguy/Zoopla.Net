using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoopla.Net.Models.GeoAutocomplete;

namespace Zoopla.Net.Models
{
    public class GeoAutocompleteResponse : ResponseModelBase
    {
        public List<Suggestion> Suggestions { get; set; }
    }
}
