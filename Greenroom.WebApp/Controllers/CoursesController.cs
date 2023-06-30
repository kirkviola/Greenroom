using Greenroom.Application.Actions.Courses.Interfaces;
using Greenroom.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Greenroom.WebApp.Controllers
{
    public class CoursesController : ApiControllerBase
    {
        private readonly IGetCourseById _getCourseById;
        private readonly IGetCoursesByUserId _getCoursesByUserId;

        public CoursesController(IGetCourseById getCourseById, IGetCoursesByUserId getCoursesByUserId)
        {
            _getCourseById = getCourseById;
            _getCoursesByUserId = getCoursesByUserId;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourseByid(int id)
        {
            return await _getCourseById.GetByIdAsync(id);
        }

        [HttpGet("coursesByUserId")]
        public async Task<ActionResult<List<Course>>> GetCoursesByUserId([FromQuery] int userId)
        {
            return await _getCoursesByUserId.GetCoursesAsync(userId);
        }
    }
}
