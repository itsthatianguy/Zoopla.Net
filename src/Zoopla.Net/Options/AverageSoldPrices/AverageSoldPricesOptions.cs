using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Zoopla.Net.Options.Enums;

namespace Zoopla.Net.Options.AverageSoldPrices
{
    public class AverageSoldPricesOptions
    {
        internal AreaType _areaType;
        internal string _postcode;
        internal string Url;
        internal Dictionary<string, string> UrlValues { get; set; }

        public string PostCode
        {
            get
            {
                return _postcode;
            }
            set
            {
                // Remove spaces from the postcode
                _postcode = Regex.Replace(value, @"\s+", "");
            }
        }
        public OutputType OutputType { get; set; }

        // TODO: There seems to be some confusion over what the docs say, and what actually works here...
        /// <summary>
        /// Area Type has to be compatible with Output Type. If they are not compatible, value will not be set.
        /// See http://developer.zoopla.com/docs/read/Average_Sold_Prices for compatible values
        /// </summary>
        public AreaType AreaType
        {
            get
            {
                return _areaType;
            }
            set
            {
                // TODO: Is there a way to get rid of this damn ugly switch statement?
                switch (OutputType)
                {
                    case OutputType.AREA:
                    case OutputType.OUTCODE:
                        if (value == AreaType.STREETS ||
                            value == AreaType.POSTCODES)
                        {
                            _areaType = value;
                        }
                        break;
                    case OutputType.TOWN:
                        if (value == AreaType.STREETS ||
                            value == AreaType.OUTCODES)
                        {
                            _areaType = value;
                        }
                        break;
                    case OutputType.COUNTY:
                        if (value == AreaType.AREAS ||
                            value == AreaType.OUTCODES ||
                            value == AreaType.STREETS ||
                            value == AreaType.TOWNS)
                        {
                            _areaType = value;
                        }
                        break;
                    case OutputType.COUNTRY:
                        if (value == AreaType.AREAS ||
                            value == AreaType.COUNTIES ||
                            value == AreaType.OUTCODES ||
                            value == AreaType.STREETS ||
                            value == AreaType.TOWNS)
                        {
                            _areaType = value;
                        }
                        break;
                }
            }
        }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public Ordering Ordering { get; set; }


        internal void AddProperties()
        {
            UrlValues.Add("postcode", PostCode?.ToLower());
            UrlValues.Add("output_type", OutputType.ToString()?.ToLower());
            UrlValues.Add("area_type", AreaType.ToString()?.ToLower());
            UrlValues.Add("ordering", Ordering.ToString()?.ToLower());
            UrlValues.Add("page_number", PageNumber.ToString()?.ToLower());
            UrlValues.Add("page_size", PageSize.ToString()?.ToLower());
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
