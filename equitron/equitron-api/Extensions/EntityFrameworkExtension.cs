

using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace equitron_api.Extensions
{
    public static class EntityFrameworkExtension
    {
        public static void AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EquitronContext>(c =>
            {
                c.UseNpgsql(configuration.GetConnectionString("DBConnection"));
            });
        }
    }
}
