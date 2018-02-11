using System.Threading.Tasks;
using NUnit.Framework;
using Zoopla.Net.Core;
using Zoopla.Net.Core.Models.AreaValueGraphs;
using Zoopla.Net.Core.Options;
using Zoopla.Net.Core.Options.AreaValueGraphs;
using Zoopla.Net.Core.Options.Enums;

namespace Zoopla.Net.Specs
{
    [TestFixture]
    public class GetAreaValueGraphsSpecs
    {
        [Test]
        public async Task Should_Get_GetAreaValueGraphs()
        {
            AreaValueGraphResponse result;
            using (var api = new ZooplaDotNetClient(ApiKey.Value))
            {
                var options = new AreaValueGraphOptions { Size = Size.MEDIUM };
                var parameters = new StandardLocationParameters { PostCode = "e84dt" };

                result = await api.GetAreaValueGraphs(parameters, options);
            }


            Assert.That(result.AverageValuesGraphUrl,
                Is.EqualTo("https://www.zoopla.co.uk/dynimgs/graph/average_prices/E8?width=400&height=212"));
        }
    }
}