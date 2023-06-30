using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Application.Exceptions
{
    public class CourseNotFoundException : Exception
    {
        public CourseNotFoundException(int id): base($"No course found with given id: {id}") { }
    }
}
