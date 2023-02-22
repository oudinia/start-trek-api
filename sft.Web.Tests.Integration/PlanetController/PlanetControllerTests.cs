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
        var client = _apiFactory.CreateClient();
        var expectedPlanetCount = 15;
        
        // Act
        var planetsResponse = await client.GetAsync("api/planets");
        var response = await planetsResponse.Content.ReadAsStringAsync();
        var planets = JsonSerializer.Deserialize<Planet[]>(response);

        // Assert
        var actualPlanetCount = planets?.Length;
        Assert.True(Equals(actualPlanetCount, expectedPlanetCount));
    }
}