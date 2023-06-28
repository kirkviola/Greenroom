using Greenroom.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenroom.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration) 
        {
            // Local connection string from user secrets
            var connectionString = configuration["dev:ConnectionString"]!;

            services.AddDbContext<GreenroomDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(connectionString)));

            services.AddScoped<IGreenroomDbContext>(provider => provider.GetRequiredService<GreenroomDbContext>());

            // TODO: Add other services like authorization, jwt etc.

            return services;
        }
    }
}
