using Microsoft.EntityFrameworkCore;
using SRCM.Infra.Data.Mapping;

namespace SRCM.Infra.Data.Context
{
    public class SRCMDbContext : DbContext
    {
        public SRCMDbContext(DbContextOptions<SRCMDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressMap());
            modelBuilder.ApplyConfiguration(new AppointmentMap());
            modelBuilder.ApplyConfiguration(new AppointmentSchedulingMap());
            modelBuilder.ApplyConfiguration(new DoctorMap());
            modelBuilder.ApplyConfiguration(new PatientMap());
            modelBuilder.ApplyConfiguration(new StaffMap());


            base.OnModelCreating(modelBuilder);
        }
    }
}
