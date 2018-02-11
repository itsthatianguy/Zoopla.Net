using Zoopla.Net.Core.Options.Enums;

namespace Zoopla.Net.Core.Options.AreaValueGraphs
{
    public class AreaValueGraphOptions : OptionsBase
    {
        public AreaValueGraphOptions()
        {
            Size = Size.MEDIUM;
        }

        public Size Size
        {
            set => UrlValues["size"] = value.ToString()?.ToLower();
        }
    }
}
