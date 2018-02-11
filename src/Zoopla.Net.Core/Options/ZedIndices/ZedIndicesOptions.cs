using Zoopla.Net.Core.Options.Enums;

namespace Zoopla.Net.Core.Options.ZedIndices
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
            set => UrlValues["ordering"] = value.ToString()?.ToLower();
        }
        /// <summary>
        /// Defaults to 1
        /// </summary>
        public int PageNumber
        {
            set => UrlValues["page_number"] = value.ToString();
        }

        /// <summary>
        /// Defaults to 10, maximum 20
        /// </summary>
        public int PageSize
        {
            set => UrlValues["page_size"] = value.ToString();
        }
    }
}
