using Microsoft.AspNetCore.Mvc;
using university_applications.Services;

namespace university_applications.Controllers
{
  [ApiController]
  [Route("university")]
  public class UniversityController : ControllerBase, IUniversityController
  {
    private readonly IUniversityService _service;
    public UniversityController(IUniversityService service)
    {
      _service = service;
    }
    [HttpGet]
    [Route("{country}")]
    public ActionResult FindUniversity(string country)
    {
      var universities = _service.FindUniversity(country);
      if (universities.Result == null)
      return BadRequest();
      return Ok(universities.Result);
    }
    [HttpGet]
    [Route("{name}/{country}")]
    public ActionResult FindUniversity(string country, string name)
    {
      var universities = _service.FindUniversity(name, country);
      if (universities.Result == null)
        return BadRequest();
      return Ok(universities.Result);
    }
  }
}

