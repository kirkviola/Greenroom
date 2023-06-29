using Greenroom.Application.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
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
            var connectionString = configuration["Dev:ConnectionString"]!;

            services.AddDbContext<GreenroomDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IGreenroomDbContext>(provider => provider.GetRequiredService<GreenroomDbContext>());

            // TODO: Add other services like authorization, jwt etc.
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = configuration["Dev:Jwt:Issuer"],
                    ValidAudience = configuration["Dev:Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey
                        (Encoding.ASCII.GetBytes(configuration["Dev:Jwt:Key"]!)),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                };
            });

            return services;
        }
    }
}
