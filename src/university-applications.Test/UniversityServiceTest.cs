using Moq;
using university_applications.Services;
using System.Text.Json;

namespace university_applications.Test;

public class UniversityServiceTest
{

  [Fact]
  public async Task ShouldReturnUniversityByCountryAndName()
  {
    var mockClient = new Mock<HttpClient>();
    var service = new UniversityService(mockClient.Object);
    var result = await service.FindUniversity("turkey", "middle");

    result.Should().BeOfType<JsonElement>();
  }

  [Fact]
  public async Task ShouldReturnAUniversityByCountry()
  {
    var mockClient = new Mock<HttpClient>();
    var service = new UniversityService(mockClient.Object);
    var result = await service.FindUniversity("turkey");

    result.Should().BeOfType<JsonElement>();
  }
}

