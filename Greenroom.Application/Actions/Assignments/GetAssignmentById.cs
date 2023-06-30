using Greenroom.Application.Actions.Assignments.Interfaces;
using Greenroom.Application.Exceptions;
using Greenroom.Application.Interfaces;
using Greenroom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Application.Actions.Assignments
{
    public class GetAssignmentById : IGetAssignmentById
    {
        private readonly IGreenroomDbContext _context;
        public GetAssignmentById(IGreenroomDbContext context)
        {
            _context = context;
        }

        public async Task<Assignment> GetAsync(int id)
        {
            return await _context.Assignments
                .SingleOrDefaultAsync(x => x.Id == id)
                  ?? throw new AssignmentNotFoundException(id);
        }
    }
}
