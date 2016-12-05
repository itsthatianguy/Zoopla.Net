using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Zoopla.Net.Options.Enums;

namespace Zoopla.Net.Options.AreaValueGraphs
{
    public class AreaValueGraphOptions : OptionsBase
    {
        public AreaValueGraphOptions()
        {
            Size = Size.MEDIUM;
        }

        public Size Size
        {
            set
            {
                UrlValues["size"] = value.ToString()?.ToLower();
            }
        }
    }
}
