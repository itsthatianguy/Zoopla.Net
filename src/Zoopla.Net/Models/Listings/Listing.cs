using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zoopla.Net.Models.Listings
{
    public class Listing
    {
        /// <summary>
        /// e.g. gb (Undocumented - use with caution)
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
        [JsonProperty("num_floors")]
        public int NumberOfFloors { get; set; }
        /// <summary>
        /// 150px X 113px image. (Undocumented - use with caution)
        /// </summary>
        [JsonProperty("image_150_113_url")]
        public string ImageSmall { get; set; }
        /// <summary>
        /// The current listings status of this property, either "sale" or "rent".
        /// </summary>
        [JsonProperty("listing_status")]
        public string ListingStatus { get; set; }
        [JsonProperty("num_bedrooms")]
        public int NumberOfBedrooms { get; set; }
        /// <summary>
        /// 50px X 38px image. (Undocumented - use with caution)
        /// </summary>
        [JsonProperty("image_50_38_url")]
        public string ImageTiny { get; set; }
        public double Latitude { get; set; }
        [JsonProperty("agent_address")]
        public string AgentAddress { get; set; }
        /// <summary>
        /// e.g. Residential (Undocumented - use with caution)
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("property_type")]
        public string PropertyType { get; set; }
        public double Longitude { get; set; }
        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
        public string Description { get; set; }
        [JsonProperty("post_town")]
        public string PostTown { get; set; }
        [JsonProperty("details_url")]
        public string DetailsUrl { get; set; }
        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }
        public string Outcode { get; set; }
        /// <summary>
        /// Undocumented - use with caution
        /// </summary>
        [JsonProperty("property_report_url")]
        public string PropertyReportUrl { get; set; }
        /// <summary>
        /// List of all images for carousel in 354px X 255px (same as ImageLarge size). (Undocumented - use with caution)
        /// </summary>
        [JsonProperty("other_image")]
        public IEnumerable<ImageAndDescription> OtherImages { get; set; }
        /// <summary>
        /// 645px X 430px image. (Undocumented - use with caution)
        /// </summary>
        [JsonProperty("image_645_430_url")]
        public string ImageExtraLarge { get; set; }
        public string County { get; set; }
        public int Price { get; set; }
        [JsonProperty("listing_id")]
        public int ListingId { get; set; }
        [JsonProperty("image_caption")]
        public string ImageCaption { get; set; }
        /// <summary>
        /// List of key bullet point features. (Undocumented - use with caution)
        /// </summary>
        [JsonProperty("bullet")]
        public IEnumerable<string> BulletPoints { get; set; }
        /// <summary>
        /// 80px X 60px image. (Undocumented - use with caution)
        /// </summary>
        [JsonProperty("image_80_60_url")]
        public string ImageThumbnail { get; set; }
        /// <summary>
        /// e.g. 5 Oldman Court (Undocumented - use with caution)
        /// </summary>
        [JsonProperty("property_number")]
        public string PropertyName { get; set; }
        public string Status { get; set; }
        [JsonProperty("agent_name")]
        public string AgentName { get; set; }
        [JsonProperty("num_recepts")]
        public int NumberOfReceptions { get; set; }
        public string Country { get; set; }
        [JsonProperty("displayable_address")]
        public string DisplayableAddress { get; set; }
        [JsonProperty("first_published_date")]
        public DateTime FirstPublishedDate { get; set; }
        [JsonProperty("floor_plan")]
        public IEnumerable<string> FloorPlan { get; set; }
        [JsonProperty("street_name")]
        public string StreetName { get; set; }
        [JsonProperty("num_bathrooms")]
        public int NumberOfBathrooms { get; set; }
        /// <summary>
        /// Undocumented - use with caution
        /// </summary>
        public string Incode { get; set; }
        [JsonProperty("price_change")]
        public IEnumerable<PriceChange> PriceChange { get; set; }
        [JsonProperty("agent_logo")]
        public string AgentLogo { get; set; }
        [JsonProperty("agent_phone")]
        public string AgentPhone { get; set; }
        /// <summary>
        /// 354px X 255px image. (Undocumented - use with caution)
        /// </summary>
        [JsonProperty("image_354_255_url")]
        public string ImageLarge { get; set; }
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
        [JsonProperty("last_published_date")]
        public DateTime LastPublishedDate { get; set; }
        [JsonProperty("price_change_summary")]
        public PriceChangeSummary PriceChangeSummary { get; set; }
        [JsonProperty("price_modifier")]
        public string PriceModifier { get; set; }
        /// <summary>
        /// Undocumented - use with caution
        /// </summary>
        [JsonProperty("new_home")]
        public string NewHome { get; set; }
        /// <summary>
        /// Undocumented - use with caution
        /// </summary>
        [JsonProperty("letting_fees")]
        public string LettingFees { get; set; }
        /// <summary>
        /// Undocumented - use with caution
        /// </summary>
        [JsonProperty("original_image")]
        public IEnumerable<string> OriginalImages { get; set; }
    }
}
