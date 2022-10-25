using Moq;
using university_applications.Services;
using System.Text.Json;

namespace university_applications.Test;

public class UniversityServiceTest
{

    [Fact]
    public async Task ShouldReturnUniversityByCountryAndName()
    {
        var client = new Mock<HttpClient>();
        var service = new UniversityService(client.Object);
        var result = await service.FindUniversity("middle", "turkey");
        result.Should().BeOfType<JsonElement>();
        result.ToString().Should().Contain("state-province");
        result.ToString().Should().Contain("name");
    }

    [Fact]
    public async Task ShouldReturnAUniversityByCountry()
    {
        var client = new Mock<HttpClient>();
        var service = new UniversityService(client.Object);
        var result = await service.FindUniversity("turkey");
        result.Should().BeOfType<JsonElement>();
        result.ToString().Should().Contain("state-province");
        result.ToString().Should().Contain("name");
    }
}

