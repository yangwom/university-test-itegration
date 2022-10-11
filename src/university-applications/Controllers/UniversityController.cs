using Microsoft.AspNetCore.Mvc;

namespace university_applications.Controllers
{
  [ApiController]
  [Route("university")]
  public class UniversityController : ControllerBase, IUniversityController
  {
    public UniversityController()
    {
      throw new System.NotImplementedException();
    }
  }
}
