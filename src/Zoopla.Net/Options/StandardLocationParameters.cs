using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Options
{
    public class StandardLocationParameters
    {
        internal string Url;
        internal Dictionary<string, string> UrlValues { get; set; }

        public string Area { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public OutputType OutputType { get; set; }

        public string GetUrlString()
        {
            UrlValues = new Dictionary<string, string>();

            AddProperties();

            return ConstructUrl();
        }

        internal void AddProperties()
        {
            UrlValues.Add("area", Area?.ToLower());
            UrlValues.Add("postcode", PostCode?.ToLower());
            UrlValues.Add("street", Street?.ToLower());
            UrlValues.Add("town", Town?.ToLower());
            UrlValues.Add("county", County?.ToLower());
            UrlValues.Add("country", Country?.ToLower());
            UrlValues.Add("output_type", OutputType.ToString()?.ToLower());
        }

        internal string ConstructUrl()
        {
            // Construct url from dictionary
            foreach (KeyValuePair<string, string> keyValue in UrlValues)
            {
                // Some values can be 0...
                if (keyValue.Value != String.Empty &&
                    keyValue.Value != null &&
                    keyValue.Value != "0")
                {
                    Url += "&" + keyValue.Key + "=" + keyValue.Value;
                }
            }

            return Url;
        }
    }
}
