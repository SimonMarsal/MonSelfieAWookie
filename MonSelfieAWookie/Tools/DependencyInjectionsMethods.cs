using Microsoft.Extensions.DependencyInjection;

using SelfieAWookie.Core.Domain;
using SelfieAWookie.Core.Infrastructure.Selfies;
using SelfieAWookie.Core.Infrastructure.Weapons;
using SelfieAWookie.Core.Infrastructure.Wookies;

namespace MonSelfieAWookie.Tools
{
    public static class DependencyInjectionsMethods
    {
        public static void AddCustomDI(this IServiceCollection services)
        {
            services.AddScoped<IWookieRepository, DbWookieRepository>();
            services.AddScoped<ISelfieRepository, DbSelfieRepository>();
            services.AddScoped<IWeaponRepository, DbWeaponRepository>();
        }
    }
}
