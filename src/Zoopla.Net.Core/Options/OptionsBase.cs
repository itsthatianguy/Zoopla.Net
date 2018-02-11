using System.Collections.Specialized;
using System.Linq;

namespace Zoopla.Net.Core.Options
{
    public class OptionsBase
    {
        internal NameValueCollection UrlValues { get; set; }

        public OptionsBase()
        {
            UrlValues = new NameValueCollection();
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
