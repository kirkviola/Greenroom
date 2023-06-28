using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Domain.Entities
{
    public class UserCourse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public bool IsInstructor { get; set; } = false;

        public virtual Course Course { get; set; }
        public virtual User User { get; set; }

        public UserCourse() 
        {
            this.Course = new Course();
            this.User = new User();
        }

        public UserCourse(Course course, User user)
        {
            this.Course = course;
            this.User = user;
        }
    }
}
