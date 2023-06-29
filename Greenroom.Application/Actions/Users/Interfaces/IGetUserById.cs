using Greenroom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Application.Actions.Users.Interfaces
{
    public interface IGetUserById
    {
        Task<User> GetUserAsync(int id);
    }
}
