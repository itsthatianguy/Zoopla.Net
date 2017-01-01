using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Zoopla.Net.Options.Enums;

namespace Zoopla.Net.Options
{
    public class ZedIndicesOptions : OptionsBase
    {
        public ZedIndicesOptions()
        {
            PageNumber = 1;
            PageSize = 20;
        }

        public Ordering Ordering
        {
            set
            {
                UrlValues["ordering"] = value.ToString()?.ToLower();
            }
        }
        /// <summary>
        /// Defaults to 1
        /// </summary>
        public int PageNumber
        {
            set
            {
                UrlValues["page_number"] = value.ToString();
            }
        }

        /// <summary>
        /// Defaults to 10, maximum 20
        /// </summary>
        public int PageSize
        {
            set
            {
                UrlValues["page_size"] = value.ToString();
            }
        }
    }
}
