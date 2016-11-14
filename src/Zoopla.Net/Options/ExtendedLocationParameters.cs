using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Options
{
    public class ExtendedLocationParameters : StandardLocationParameters
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public float LatMax { get; set; }
        public float LatMin { get; set; }
        public float LonMax { get; set; }
        public float LonMin { get; set; }

        public void GetUrlString()
        {
            UrlValues = new Dictionary<string, string>();

            base.AddProperties();
            AddProperties();

            base.ConstructUrl();
        }

        internal void AddProperties()
        {
            base.AddProperties();
        }
    }
}
