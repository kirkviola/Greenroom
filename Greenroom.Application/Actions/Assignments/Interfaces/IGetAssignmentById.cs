using Greenroom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Application.Actions.Assignments.Interfaces
{
    public interface IGetAssignmentById
    {
        Task<Assignment> GetAsync(int id);
    }
}
