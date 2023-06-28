using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Domain.Entities
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public byte[]? Attachment { get; set; } = null;
        public string? Url { get; set; } = null;

        public virtual IEnumerable<ResponseMaterial> ResponseMaterials { get; set; }

        public Material() 
        {
            this.ResponseMaterials = new List<ResponseMaterial>();
        }
    }
}
