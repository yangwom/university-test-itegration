using Moq;
using university_applications.Services;
using System.Text.Json;

namespace university_applications.Test;

public class UniversityIntegrationTest: IClassFixture<TestingWebAppFactory<Program>>
{
   readonly HttpClient _client;
 
  public UniversityIntegrationTest(TestingWebAppFactory<Program> factory)
  {
    _client = factory.CreateClient();
  }

  [Theory]
  [InlineData("Brazil", "federal")]
  [InlineData("Brazil", "acre")]

  public async Task ShouldFindAUniversityByCountryAndName(string country, string name)
  {
     var response = await _client.GetAsync($"university/{country}/{name}");
    response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
  }

  [Theory]
  [InlineData("Brazil")]
  [InlineData("Turkey")]
  public async Task ShouldFindAUniversityByCountry(string country)
  {
    var response = await _client.GetAsync($"university/{country}");
    response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
  }
}