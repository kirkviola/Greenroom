using Greenroom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Application.Interfaces
{
    public interface IGreenroomDbContext
    {
        DbSet<User> Users { get; }
        DbSet<Course> Courses { get; }
        DbSet<UserCourse> UserCourses { get; }
        DbSet<Assignment> Assignments { get; }
        DbSet<AssignmentResponse> AssignmentResponses { get; }
        DbSet<Material> Materials { get; }
        DbSet<ResponseMaterial> ResponseMaterials { get; }
    }
}
