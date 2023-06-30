using Greenroom.Application.Actions.Courses.Interfaces;
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
    public class GetCoursesByUserId : IGetCoursesByUserId
    {
        private readonly IGreenroomDbContext _context;
        public GetCoursesByUserId(IGreenroomDbContext context)
        {
            _context = context;
        }

        public async Task<List<Course>> GetCoursesAsync(int userId)
        {
            return await _context.Courses
                .Where(x => x.UserCourseId == userId)
                .ToListAsync() ?? new List<Course>();
        }
    }
}
