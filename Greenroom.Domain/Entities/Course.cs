using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; } = null;
        public int UserCourseId { get; set; }

        public virtual IEnumerable<UserCourse> UserCourses { get; set; }
        public virtual IEnumerable<Assignment> Assignments { get; set; }

        public Course() 
        {
            this.UserCourses = new List<UserCourse>();
            this.Assignments = new List<Assignment>();
        }
    }
}
