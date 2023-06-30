using Greenroom.Application.Actions.Users.Interfaces;
using Greenroom.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Greenroom.WebApp.Controllers
{
    //[Authorize]
    public class UsersController : ApiControllerBase
    {
        private readonly IGetUserById _getUserById;

        public UsersController(IGetUserById getUserById)
        {
            _getUserById = getUserById;
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetUserById([FromQuery] int id)
        {
            return await _getUserById.GetUserAsync(id);
        }
    }
}
