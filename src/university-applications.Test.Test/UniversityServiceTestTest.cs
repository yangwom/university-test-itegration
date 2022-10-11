namespace university_applications.Test.Test;

public class UniversityServiceTestTest
{

  [Trait("Category", "2 - Faça testes de integração na sua API")]
  [Fact(DisplayName = "ShouldReturnUniversityByCountryAndName deve ser executado com sucesso com o input de sucesso")]
  public async Task ShouldReturnUniversityByCountryAndName()
  {
    var _testService = new UniversityServiceTest();
    Func<Task> task = async () => await _testService.ShouldReturnUniversityByCountryAndName();
    await task.Should().NotThrowAsync<Xunit.Sdk.XunitException>();
    await task.Should().NotThrowAsync<NotImplementedException>();
  }

  [Trait("Category", "2 - Faça testes de integração na sua API")]
  [Fact(DisplayName = "ShouldReturnAUniversityByCountry deve ser executado com sucesso com o input de sucesso")]
  public async void ShouldReturnAUniversityByCountry()
  {
    var _testService = new UniversityServiceTest();
    Func<Task> task = async () => await _testService.ShouldReturnAUniversityByCountry();
    await task.Should().NotThrowAsync<Xunit.Sdk.XunitException>();
    await task.Should().NotThrowAsync<NotImplementedException>();
  }
}