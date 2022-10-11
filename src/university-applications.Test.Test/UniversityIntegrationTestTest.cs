namespace university_applications.Test.Test;

public class UniversityIntegrationTestTest
{
  TestingWebAppFactory<Program> _factory = new TestingWebAppFactory<Program>();

  [Trait("Category", "1 - Crie os endpoints para a sua API e os crie testes unitários")]
  [Theory(DisplayName = "ShouldFindAUniversityByCountryAndName deve ser executado com sucesso com o input de sucesso")]
  [InlineData("Brazil", "federal", true)]
  [InlineData("Brazil", "acre", true)]
  [InlineData("Lugar", "Distante", false)]
  public async void ShouldFindAUniversityByCountryAndName(string country, string name, bool isCorrect)
  {
    UniversityIntegrationTest instance = new(_factory);
    Func<Task> task = async () => await instance.ShouldFindAUniversityByCountryAndName(country, name);
    if (isCorrect)
    {
      await task.Should().NotThrowAsync<Xunit.Sdk.XunitException>();
      await task.Should().NotThrowAsync<NotImplementedException>();
    }
    else
    {
      await task.Should().NotThrowAsync<NotImplementedException>();
      await task.Should().ThrowAsync<Xunit.Sdk.XunitException>();
    }
  }

  [Trait("Category", "1 - Crie os endpoints para a sua API e os crie testes unitários")]
  [Theory(DisplayName = "ShouldFindAUniversityByCountry deve ser executado com sucesso com o input de sucesso")]
  [InlineData("Italy", true)]
  [InlineData("Brazil", true)]
  [InlineData("Poneilandia", false)]
  public async void ShouldFindAUniversityByCountry(string country, bool isCorrect)
  {
    UniversityIntegrationTest instance = new(_factory);
    Func<Task> task = async () => await instance.ShouldFindAUniversityByCountry(country);
    if (isCorrect)
    {
      await task.Should().NotThrowAsync<Xunit.Sdk.XunitException>();
      await task.Should().NotThrowAsync<NotImplementedException>();
    }
    else
    {
      await task.Should().NotThrowAsync<NotImplementedException>();
      await task.Should().ThrowAsync<Xunit.Sdk.XunitException>();
    }
  }

}