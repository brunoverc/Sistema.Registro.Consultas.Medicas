using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SRCM.Domain.Entities;

namespace SRCM.Infra.Data.Mapping
{
    public class AppointmentMap : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.ToTable("Appointment");
            builder.Property(appointment => appointment.IdDoctor).IsRequired();
            builder.Property(appointment => appointment.IdPatient).IsRequired();
            builder.Property(appointment => appointment.Type).IsRequired();
            builder.Property(appointment => appointment.Observation).HasMaxLength(250);

            builder.HasKey(appointment => appointment.Id);
        }
    }
}
