using Greenroom.Core.Interfaces;
using Greenroom.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Greenroom.Infrastructure;

public class GreenroomDbContext : DbContext, IGreenroomDbContext
{
    public DbSet<User> Users { get; set; }
}
