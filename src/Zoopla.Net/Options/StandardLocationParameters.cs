using System;
using System.Collections.Generic;
using System.Linq;
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
                UrlValues["postcode"] = value?.ToLower();
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
        public OutputType OutputType
        {
            set
            {
                UrlValues["output_type"] = value.ToString()?.ToLower();
            }
        }
    }
}
