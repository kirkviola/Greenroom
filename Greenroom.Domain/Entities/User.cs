using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public IEnumerable<UserCourse> UserCourses { get; set; }
        public IEnumerable<AssignmentResponse> AssignmentResponses { get; set; }

        public User() 
        {
            this.UserCourses = new List<UserCourse>(); 
            this.AssignmentResponses = new List<AssignmentResponse>();
        }
    }
}
