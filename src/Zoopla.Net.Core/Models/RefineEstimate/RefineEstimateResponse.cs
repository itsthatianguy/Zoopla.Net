using Newtonsoft.Json;

namespace Zoopla.Net.Core.Models.RefineEstimate
{
    public class RefineEstimateResponse : ResponseModelBase
    {
        public string Estimate { get; set; }

        [JsonProperty("upper_estimate")]
        public string UpperEstimate { get; set; }

        [JsonProperty("lower_estimate")]
        public string LowerEstimate { get; set; }

        /// <summary>
        /// Gets or sets the confidence.
        /// </summary>
        /// <value>
        /// Between 0 and 10
        /// </value>
        [JsonProperty("confidence_rating")]
        public float ConfidenceRating { get; set; }
    }
}
