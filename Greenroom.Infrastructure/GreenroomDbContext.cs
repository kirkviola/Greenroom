using Greenroom.Application.Interfaces;
using Greenroom.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Greenroom.Infrastructure;

public class GreenroomDbContext : DbContext, IGreenroomDbContext
{
    public DbSet<User> Users { get; set; }
}
