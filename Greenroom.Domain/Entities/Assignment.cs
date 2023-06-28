using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Domain.Entities
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double? MaxValue { get; set; } = null;
        [Timestamp]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Timestamp]
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual IEnumerable<AssignmentResponse> AssignmentResponses { get; set; }

        public Assignment() 
        { 
            this.Course = new Course();
            this.AssignmentResponses = new List<AssignmentResponse>();
        }
    }
}
