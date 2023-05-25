using Core.Users.App;
using Core.Users.Domain.Services;
using Infrastructure.Repositories;

namespace equitron_api.Extensions
{
    public static class UsersExtension
    {
        public static void AddUsersServices(this IServiceCollection services)
        {
            services.AddScoped<UsersService>();
            services.AddScoped<IUsersRepository, UsersRepository>();
        }
    }
}
