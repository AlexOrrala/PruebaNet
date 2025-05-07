using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaNet.Entity;
using PruebaNet.Services;

namespace PruebaNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly CoursesServices _courses;

        public CoursesController(CoursesServices courses)
        {
            _courses = courses;
        }

        [HttpGet]
        public async Task<ActionResult<List<Course>>> GetCourses()
        {
        return Ok(await _courses.GetCourses());
        }

    }
}
