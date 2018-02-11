namespace Zoopla.Net.Core.Models.ArrangeViewing
{
    public class ArrangeViewingResponse : ResponseModelBase
    {
        /// <summary>
        /// Gets or sets the success. If this value is returned as 0 from the API, the Error string will be set in the response
        /// </summary>
        /// <value>
        /// 1 if successful, 0 if not
        /// </value>
        public int Success { get; set; }

        public bool IsSuccess => Success == 1;

        public string Error { get; set; }
    }
}
