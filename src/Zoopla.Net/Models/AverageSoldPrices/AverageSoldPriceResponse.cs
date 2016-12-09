using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models.AverageSoldPrices
{
    public class AverageSoldPriceResponse : ResponseModelBase
    {
        public List<Area> Areas { get; set; }
    }
}
