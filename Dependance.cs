using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace BlogSystemAPI
{
    public static class Dependency
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services , IConfiguration configuration)
        {
            AddConnectionStringConfig(services, configuration);

            return services;
        }

        private static IServiceCollection AddConnectionStringConfig(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BlogDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
