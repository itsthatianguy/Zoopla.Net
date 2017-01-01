using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoopla.Net.Models.AverageSoldPrices;

namespace Zoopla.Net.Models
{
    public class AverageSoldPriceResponse : ResponseModelBase
    {
        public List<Area> Areas { get; set; }
    }
}
