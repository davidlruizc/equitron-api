using Core.Preferences.App;
using Core.Preferences.Domain.Services;
using Infrastructure.Repositories;

namespace equitron_api.Extensions
{
    public static class PreferencesExtension
    {
        public static void AddPreferencesServices(this IServiceCollection services)
        {
            services.AddScoped<PreferencesService>();
            services.AddScoped<IPreferencesRepository, PreferencesRepository>();
        }
    }
}
