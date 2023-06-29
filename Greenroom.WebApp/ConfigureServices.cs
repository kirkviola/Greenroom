using Greenroom.Application.Actions.Users;
using Greenroom.Application.Actions.Users.Interfaces;
using System.Runtime.CompilerServices;

namespace Greenroom.WebApp
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddWebAppServices(this IServiceCollection services)
        {
            services.AddScoped<IGetUserById, GetUserById>();

            return services;
        }
    }
}
