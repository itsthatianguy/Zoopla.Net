using System.Threading.Tasks;
using NUnit.Framework;
using Zoopla.Net.Core;
using Zoopla.Net.Core.Models.AverageSoldPrices;
using Zoopla.Net.Core.Options;
using Zoopla.Net.Core.Options.AverageSoldPrices;
using Zoopla.Net.Core.Options.Enums;

namespace Zoopla.Net.Specs
{
    [TestFixture]
    public class GetGetAverageSoldPrices
    {
        [Test]
        public async Task Should_Get_GetAverageSoldPrices()
        {
            AverageSoldPriceResponse result;
            using (var api = new ZooplaDotNetClient(ApiKey.Value))
            {
                var options = new AverageSoldPricesOptions();
                var paramerters = new StandardLocationParameters
                {
                    PostCode = "e84dt",
                    OutputType = OutputType.OUTCODE,
                    AreaType = AreaType.POSTCODES
                };

                result = await api.GetAverageSoldPrices(paramerters, options); 
            }

            Assert.That(result.Areas.Count, Is.EqualTo(10));
        }
    }
}