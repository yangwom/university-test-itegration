namespace university_applications.Test;

public class UniversityIntegrationTest
{

  [Theory]
  [InlineData("Brazil", "federal")]
  [InlineData("Brazil", "acre")]

  public async Task ShouldFindAUniversityByCountryAndName(string country, string name)
  {
    throw new System.NotImplementedException();
  }

  [Theory]
  [InlineData("Brazil")]
  [InlineData("Turkey")]
  public async Task ShouldFindAUniversityByCountry(string country)
  {
    throw new System.NotImplementedException();
  }
}