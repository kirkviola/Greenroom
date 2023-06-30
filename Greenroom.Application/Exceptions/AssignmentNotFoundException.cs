using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Application.Exceptions
{
    public class AssignmentNotFoundException : Exception
    {
        public AssignmentNotFoundException(int id): base($"No Assignment found with given id: {id}") { }
    }
}
