using System.Threading.Tasks;
using NUnit.Framework;
using Zoopla.Net.Core;
using Zoopla.Net.Core.Models.AverageAreaSoldPrices;
using Zoopla.Net.Core.Options;
using Zoopla.Net.Core.Options.Enums;

namespace Zoopla.Net.Specs
{
    [TestFixture]
    public class GetAverageAreaSoldPriceSpecs
    {
        [Test]
        public async Task Should_Get_GetAverageAreaSoldPrice()
        {
            AverageAreaSoldPriceResponse result;
            using (var api = new ZooplaDotNetClient(ApiKey.Value))
            {
                var parameters = new StandardLocationParameters { PostCode = "e8", OutputType = OutputType.OUTCODE };

                result = await api.GetAverageAreaSoldPrice(parameters);
            }


            Assert.That(result.PricesUrl,
                Is.EqualTo("https://www.zoopla.co.uk/home-values/london/e8/hackney-dalston"));
        }
    }
}