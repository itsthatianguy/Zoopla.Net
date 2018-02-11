using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Zoopla.Net.Core.Options.Enums;

namespace Zoopla.Net.Core.Options.AverageAreaSoldPrices
{
    public class AverageAreaSoldPriceOptions
    {
        internal string Url;
        internal Dictionary<string, string> UrlValues { get; set; }
        internal AreaType _areaType;
        internal string _postcode;

        public string PostCode
        {
            get => _postcode;
            set => _postcode = Regex.Replace(value, @"\s+", "");
        }
        public OutputType OutputType { get; set; }
        public AreaType AreaType
        {
            get => _areaType;
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

        internal void AddProperties()
        {
            UrlValues.Add("postcode", PostCode?.ToLower());
            UrlValues.Add("output_type", OutputType.ToString()?.ToLower());
            UrlValues.Add("area_type", AreaType.ToString()?.ToLower());
        }

        internal string ConstructUrl()
        {
            // Construct url from dictionary
            foreach (var keyValue in UrlValues)
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
