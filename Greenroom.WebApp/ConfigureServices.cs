using Greenroom.Application.Actions.Assignments;
using Greenroom.Application.Actions.Assignments.Interfaces;
using Greenroom.Application.Actions.Courses;
using Greenroom.Application.Actions.Courses.Interfaces;
using Greenroom.Application.Actions.Users;
using Greenroom.Application.Actions.Users.Interfaces;
using System.Runtime.CompilerServices;

namespace Greenroom.WebApp
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddWebAppServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Use case registry
            services.AddScoped<IGetUserById, GetUserById>();
            services.AddScoped<IGetCourseById, GetCourseById>();
            services.AddScoped<IGetCoursesByUserId, GetCoursesByUserId>();
            services.AddScoped<IGetAssignmentById, GetAssignmentById>();

            // Limited CORS policy
            var localOriginConfig = configuration.GetValue<string>("LocalOrigin");
            if (localOriginConfig != null)
            {
                services.AddCors(options =>
                {
                    options.AddPolicy(name: localOriginConfig,
                        policy =>
                        {
                            var origins = configuration.GetValue<string>("AllowedOrigins");
                            if (origins != null)
                            {
                                policy.WithOrigins(origins);
                            }
                        });
                });

            }

            return services;
        }
    }
}
