using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models.AverageSoldPrices
{
    public class Area
    {
        [JsonProperty("number_of_sales_7year")]
        public string NumberOfSales7Year { get; set; }

        [JsonProperty("average_sold_price_7year")]
        public string AverageSoldPrice7Year { get; set; }

        [JsonProperty("number_of_sales_5year")]
        public string NumberOfSales5Year { get; set; }

        [JsonProperty("number_of_sales_3year")]
        public string NumberOfSales3Year { get; set; }

        [JsonProperty("average_sold_price_1year")]
        public string AverageSoldPrice1Year { get; set; }

        [JsonProperty("number_of_sales_1year")]
        public string NumberOfSales1Year { get; set; }

        public string Turnover { get; set; }

        [JsonProperty("prices_url")]
        public string PricesUrl { get; set; }

        [JsonProperty("average_sold_price_3year")]
        public string AverageSoldPrice3Year { get; set; }

        [JsonProperty("average_sold_price_5year")]
        public string AverageSoldPrice5Year { get; set; }
    }
}
