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
        [Route("{name}/{country}")]
        public async Task<IActionResult> FindUniversity(string country, string name)
        {
            var response = await _service.FindUniversity(country, name);
            if (response.ToString() == "[]") return NotFound();

            return Ok(response);
        }

        [HttpGet]
        [Route("{country}")]
        public async Task<IActionResult> FindUniversity(string country)
        {
            var response = await _service.FindUniversity(country);
            if (response.ToString() == "[]") return NotFound();

            return Ok(response);

        }
    }
}
