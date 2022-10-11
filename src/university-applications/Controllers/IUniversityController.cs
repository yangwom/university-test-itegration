using Microsoft.AspNetCore.Mvc;

namespace university_applications.Controllers
{
  public interface IUniversityController
  {

    /// <summary> This function list a universities by country and name</summary>
    /// <param name="country"> a country name</param>
    /// <param name="name"> a pice of university's name</param>
    /// <returns> a university's list</returns>
    Task<IActionResult> FindUniversity(string country, string name);

    /// <summary> This function list a universities by country</summary>
    /// <param name="country"> a country name</param>
    /// <returns> a university's list</returns>
    Task<IActionResult> FindUniversity(string country);
  }
}
