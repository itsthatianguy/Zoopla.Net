using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zoopla.Net.Options
{
    public class StandardLocationParameters : OptionsBase
    {
        public string Area
        {
            set
            {
                UrlValues["area"] = value?.ToLower();
            }
        }
        public string Street
        {
            set
            {
                UrlValues["street"] = value?.ToLower();
            }
        }
        public string Town
        {
            set
            {
                UrlValues["town"] = value?.ToLower();
            }
        }
        public string PostCode
        {
            set
            {
                // Remove spaces from the postcode
                UrlValues["postcode"] = Regex.Replace(value, @"\s+", "");
            }
        }
        public string County
        {
            set
            {
                UrlValues["county"] = value?.ToLower();
            }
        }
        public string Country
        {
            set
            {
                UrlValues["country"] = value?.ToLower();
            }
        }
        public string LatMin
        {
            set
            {
                UrlValues["lat_min"] = value?.ToString().ToLower();
            }
        }
        public string LatMax
        {
            set
            {
                UrlValues["lat_max"] = value?.ToString().ToLower();
            }
        }
        public string LonMin
        {
            set
            {
                UrlValues["lon_min"] = value?.ToString().ToLower();
            }
        }
        public string LonMax
        {
            set
            {
                UrlValues["lon_max"] = value?.ToString().ToLower();
            }
        }
        public OutputType OutputType
        {
            set
            {
                UrlValues["output_type"] = value.ToString()?.ToLower();
            }
        }

        public AreaType AreaType
        {
            set
            {
                UrlValues["area_type"] = value.ToString()?.ToLower();
            }
        }
    }
}
