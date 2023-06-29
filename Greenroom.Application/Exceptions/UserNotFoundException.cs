using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Application.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(int id)
    : base($"User not found with given id: {id}")
        { }
    }
}
