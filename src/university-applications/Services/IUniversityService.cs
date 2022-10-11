namespace university_applications.Services
{
  public interface IUniversityService
  {
    Task<object> FindUniversity(string name, string country);

    Task<object> FindUniversity(string country);
  }
}
