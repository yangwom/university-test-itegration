namespace university_applications.Services
{
  public interface IUniversityService
  {
    Task<object> FindUniversity(string country, string name);

    Task<object> FindUniversity(string country);
  }
}
