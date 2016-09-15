using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoopla.Net.Options.Enums;

namespace Zoopla.Net.Options.ArrangeViewing
{
    public class ArrangeViewingOptions
    {
        internal string Url;
        internal Dictionary<string, string> UrlValues { get; set; }

        public string SessionId { get; set; }

        public string ListingId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public PhoneType PhoneType { get; set; }

        public BestTimeToCall BestTimeToCall { get; set; }

        public string Message { get; set; }

        internal void AddProperties()
        {
            UrlValues.Add("session_id", SessionId.ToLower());
            UrlValues.Add("listing_id", ListingId.ToLower());
            UrlValues.Add("name", Name.ToLower());
            UrlValues.Add("email", Email.ToLower());
            UrlValues.Add("phone", Phone.ToLower());
            UrlValues.Add("phone_type", PhoneType.ToString().ToLower());
            UrlValues.Add("best_time_to_call", BestTimeToCall.ToString().ToLower());
            UrlValues.Add("message", Message.ToLower());
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

        public string GetUrlString()
        {
            UrlValues = new Dictionary<string, string>();

            AddProperties();

            return ConstructUrl();
        }
    }
}
