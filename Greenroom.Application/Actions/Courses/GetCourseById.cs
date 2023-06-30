using Greenroom.Application.Actions.Courses.Interfaces;
using Greenroom.Application.Exceptions;
using Greenroom.Application.Interfaces;
using Greenroom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Application.Actions.Courses
{
    public class GetCourseById : IGetCourseById
    {
        private readonly IGreenroomDbContext _context;

        public GetCourseById(IGreenroomDbContext context)
        {
            _context = context;
        }

        public async Task<Course> GetByIdAsync(int id)
        {
            return await _context.Courses
                .SingleOrDefaultAsync(x => x.Id == id)
                  ?? throw new CourseNotFoundException(id);
        }
    }
}
