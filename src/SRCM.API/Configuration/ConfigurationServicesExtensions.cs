using Microsoft.EntityFrameworkCore;
using SRCM.Infra.Data.Context;
using SRCM.Infra.Identity.Data;

namespace SRCM.API.Configuration
{
    public static class ConfigurationServicesExtensions
    {
        public static IServiceCollection DbContextConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<SRCMDbContext>(options => options.UseSqlServer(connectionString));
            services.AddDbContext<IdentityDataContext>(options => options.UseSqlServer(connectionString));
            services.AddDistributedMemoryCache();
            return services;
        }
    }
}
