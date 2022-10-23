using Moq;
using university_applications.Services;
using System.Text.Json;

namespace university_applications.Test;

public class UniversityIntegrationTest
{

  TestingWebAppFactory<Program> _factory;
  public UniversityIntegrationTest(TestingWebAppFactory<Program> factory)
  {
    _factory = factory;
  }

  [Theory]
  [InlineData("Brazil", "federal")]
  [InlineData("Brazil", "acre")]

  public async Task ShouldFindAUniversityByCountryAndName(string country, string name)
  {
    var mockClient = new Mock<HttpClient>();
    var service = new UniversityService(mockClient.Object);
    var result = await service.FindUniversity("turkey", "middle");

    result.Should().BeOfType<JsonElement>();
  }

  [Theory]
  [InlineData("Brazil")]
  [InlineData("Turkey")]
  public async Task ShouldFindAUniversityByCountry(string country)
  {
    throw new System.NotImplementedException();
  }
}