using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using stf.Domain;
using stf.Model;
using stf.web;
using Xunit;

namespace sft.Web.Tests.Integration.PlanetController;

public class PlanetControllerTests : IClassFixture<WebApplicationFactory<IApiMarker>>
{
    private readonly WebApplicationFactory<IApiMarker> _apiFactory;

    public PlanetControllerTests(WebApplicationFactory<IApiMarker> apiFactory)
    {
        _apiFactory = apiFactory;
    }

    [Fact]
    public async Task TestInitialCountOfPlanetsIsFifteen()
    {
        // Arrange
        var client = GivenDefaultHttpClient();
        var expectedPlanetCount = Utilities.GivenExpectedCount(15);
        
        // Act
        var planets =  await Utilities.WhenGetSerializedResponse<Planet>("api/planets", client);

        // Assert
        var actualPlanetCount = planets?.Length;
        Assert.True(Equals(actualPlanetCount, expectedPlanetCount));
    }

    private HttpClient GivenDefaultHttpClient() 
    {
        return _apiFactory.CreateClient();
    }
}
