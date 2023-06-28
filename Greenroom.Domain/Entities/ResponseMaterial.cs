using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Domain.Entities
{
    public class ResponseMaterial
    {
        public int Id { get; set; }
        public int ResponseId { get; set; }
        public int MaterialId { get; set; }

        public virtual AssignmentResponse AssignmentResponse { get; set; }
        public virtual Material Material { get; set; }

        public ResponseMaterial() 
        {
            this.AssignmentResponse = new AssignmentResponse();
            this.Material = new Material();
        }
    }
}
