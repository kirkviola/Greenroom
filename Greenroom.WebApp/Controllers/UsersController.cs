using Greenroom.Application.Actions.Users.Interfaces;
using Greenroom.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Greenroom.WebApp.Controllers
{
    // Authorize can and will go here
    public class UsersController : ApiControllerBase
    {
        private readonly IGetUserById getUserById;

        public UsersController(IGetUserById getUserById)
        {
            this.getUserById = getUserById;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            return await getUserById.GetUserAsync(id);
        }
    }
}
