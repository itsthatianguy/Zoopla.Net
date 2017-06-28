using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoopla.Net.Options.Enums;

namespace Zoopla.Net.Options
{
    public class ArrangeViewingOptions : OptionsBase
    {
        /// <summary>
        /// For testing purposes, we have blacklisted zoopla_developer@mashery.com for your convenience. 
        /// </summary>
        public const string TestEmail = "zoopla_developer@mashery.com";

        public string SessionId
        {
            set
            {
                UrlValues["session_id"] = value;
            }
        }

        public int ListingId
        {
            set
            {
                UrlValues["listing_id"] = value.ToString();
            }
        }

        public string Name
        {
            set
            {
                UrlValues["name"] = value;
            }
        }

        public string Email
        {
            set
            {
                UrlValues["email"] = value;
            }
        }

        public string Phone
        {
            set
            {
                UrlValues["phone"] = value;
            }
        }

        public PhoneType PhoneType
        {
            set
            {
                UrlValues["phone_type"] = value.ToString()?.ToLower();
            }
        }

        public BestTimeToCall BestTimeToCall
        {
            set
            {
                UrlValues["best_time_to_call"] = value.ToString()?.ToLower();
            }
        }

        public string Message
        {
            set
            {
                UrlValues["message"] = value;
            }
        }
    }
}
