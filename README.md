# Zoopla.Net

Zoopla.Net is a C# .NET Core wrapper for the Zoopla.co.uk API.
The documentation for the Zoopla API can be found [here](http://developer.zoopla.com/docs)

Written in .Net Core 2.0

```shell
nuget - Zoopla.Net.Core
```

# Usage

```csharp
//GetAreaValueGraphs
//https://developer.zoopla.co.uk/docs/read/Area_Value_Graphs

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
```

```csharp
//GetAverageAreaSoldPrice
//https://developer.zoopla.co.uk/docs/read/Average_area_sold_price

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
```

```csharp
//GetAverageSoldPrices
//https://developer.zoopla.co.uk/docs/read/Average_Sold_Prices

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
```

