using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SRCM.Domain.Entities;
using SRCM.Domain.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Infra.Data.Mapping
{
    public class AppointmentSchedulingMap : IEntityTypeConfiguration<AppointmentScheduling>
    {
        public void Configure(EntityTypeBuilder<AppointmentScheduling> builder)
        {
            builder.ToTable("AppointmentScheduling");
            builder.Property(appsch => appsch.Date).IsRequired();
            builder.Property(appsch => appsch.IdAppointment).IsRequired();
            builder.Property(appsch => appsch.Status).IsRequired().HasDefaultValue(AppointmentStatus.Em_Agendamento);
            builder.HasKey(appsch => appsch.Id);
        }
    }
}
