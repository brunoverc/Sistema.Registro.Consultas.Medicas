using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Infra.Identity.Configurations
{
    public static class DependenceInjectionConfig
    {
        public static void RegisterService(this IServiceCollection services)
        {
            services.AddMediatr();
            services.AddRepositories();
            services.AddServices();
        }

        public static void AddMediatr(this IServiceCollection services) 
        {
            services.AddMediatR(c => c.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        }

        public static void AddRepositories(this IServiceCollection services) 
        {
        }

        public static void AddServices(this IServiceCollection services)
        {
        }
    }
}
