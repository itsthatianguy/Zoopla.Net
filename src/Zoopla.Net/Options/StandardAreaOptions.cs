using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zoopla.Net.Options
{
    public class StandardAreaOptions
    {
        public StandardAreaOptions()
        {
            UrlValues = new NameValueCollection();
        }

        internal NameValueCollection UrlValues { get; set; }

        public string PostCode
        {
            set
            {
                // Remove spaces from the postcode
                UrlValues["postcode"] = Regex.Replace(value, @"\s+", "");
            }
        }
        public OutputType OutputType {
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

        public string GetUrlParams()
        {
            var array = (from key in UrlValues.AllKeys
                         from value in UrlValues.GetValues(key)
                         select string.Format("{0}={1}", key, value))
                        .ToArray();
            return "&" + string.Join("&", array);
        }
    }
}
