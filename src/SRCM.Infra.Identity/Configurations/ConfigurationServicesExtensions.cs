using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SRCM.Infra.Data.Context;
using SRCM.Infra.Identity.Data;

namespace SRCM.Infra.Identity.Configurations
{
    public static class ConfigurationServicesExtensions
    {
        public static IServiceCollection DbContextConfigureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<SRCMDbContext>(options => options.UseSqlServer(connectionString));
            services.AddDbContext<IdentityDataContext>(options => options.UseSqlServer(connectionString));

            services.AddDistributedMemoryCache();

            return services;
        }
    }
}
