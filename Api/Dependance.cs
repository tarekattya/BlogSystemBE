using Infrastructure.Persistence.Data;
using Infrastructure.Persistence.Emtities;
using Microsoft.EntityFrameworkCore;

namespace BlogSystemAPI
{
    public static class Dependency
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services , IConfiguration configuration)
        {
            AddConnectionStringConfig(services, configuration);
            AddIdentityConfig(services);

            return services;
        }

        private static IServiceCollection AddConnectionStringConfig(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BlogDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }

        private static IServiceCollection AddIdentityConfig(IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<BlogDbContext>();
            return services;
        }

    }
}
