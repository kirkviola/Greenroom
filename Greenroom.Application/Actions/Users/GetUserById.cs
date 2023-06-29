using Greenroom.Application.Actions.Users.Interfaces;
using Greenroom.Application.Interfaces;
using Greenroom.Application.Exceptions;
using Greenroom.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Greenroom.Application.Actions.Users
{
    public class GetUserById : IGetUserById
    {
        private readonly IGreenroomDbContext _context;

        public GetUserById(IGreenroomDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await _context.Users
                .SingleOrDefaultAsync(x => x.Id == id)
                  ?? throw new UserNotFoundException(id);
        }
    }
}