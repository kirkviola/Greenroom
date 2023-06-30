using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Domain.Entities
{
    public class AssignmentResponse
    {
        public int Id { get; set; }
        public string? ResponseBody { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public int UserId { get; set; }
        public int AssignmentId { get; set; }

        public virtual Assignment Assignment { get; set; }
        public virtual User User { get; set; }
        public virtual IEnumerable<ResponseMaterial> ResponseMaterials { get; set; }
        public AssignmentResponse() 
        {
            this.Assignment = new Assignment();
            this.User = new User();
            this.ResponseMaterials = new List<ResponseMaterial>();
        }
    }
}
