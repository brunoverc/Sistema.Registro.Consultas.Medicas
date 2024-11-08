using Microsoft.AspNetCore.Identity;
using SRCM.Domain.Interfaces;
using SRCM.Domain.Shared.Transaction;
using SRCM.Infra.Data.Context;
using SRCM.Infra.Data.Repositories;
using SRCM.Infra.Data.UoW;
using SRCM.Infra.Identity.Data;
using SRCM.Infra.Identity.Services;
using SRCM.Services.AppService.Interfaces;
using SRCM.Services.AppService.Services;
using System.Reflection;

namespace SRCM.API.Configuration
{
    public static class DependenceInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddMediatr();
            services.AddRepository();
            services.AddServices();
        }
        public static void AddMediatr(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        }
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork,UnitOfWork>();
            services.AddScoped<SRCMDbContext>();
            services.AddScoped<IdentityDataContext>();

            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<IdentityDataContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<IIdentityServices, IdentityService>();

            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<IAppointmentSchedulingRepository, AppointmentSchedulingRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IStaffRepository, StaffRepository>();
        }
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAddressAppServices, AddressAppService>();
            services.AddScoped<IAppointmentAppServices, AppointmentAppService>();
            services.AddScoped<IAppointmentSchedulingAppServices, AppointmentSchedulingAppService>();
            services.AddScoped<IDoctorAppServices, DoctorAppService>();
            services.AddScoped<IPatientAppServices, PatientAppService>();
            services.AddScoped<IStaffAppServices, StaffAppService>();
        }
    }
}
