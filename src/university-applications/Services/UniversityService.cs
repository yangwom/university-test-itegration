namespace university_applications.Services
{
  public class UniversityService : IUniversityService
  {
  
    private readonly HttpClient _client;
    public UniversityService(HttpClient client)
    {
      _client = client;
    }

      public async Task<object> FindUniversity(string country, string name)
    {
      var response = await _client.GetAsync($"http://universities.hipolabs.com/search?name={name}&country={country}");
      var result = await response.Content.ReadFromJsonAsync<object>();
      if (result.ToString() != "[]")
      {
        return result;
      }
      return null;
    }
    

    public async Task<object> FindUniversity(string country)
    {
      var response = await _client.GetAsync($"http://universities.hipolabs.com/search?country={country}");
      var result = await response.Content.ReadFromJsonAsync<object>();
      if (result.ToString() != "[]")
      {
        return result;
      }
      return null;
    }
  }
}

