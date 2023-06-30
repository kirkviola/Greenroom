using Greenroom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Application.Actions.Courses.Interfaces
{
    public interface IGetCoursesByUserId
    {
        Task<List<Course>> GetCoursesAsync(int userId);
    }
}
