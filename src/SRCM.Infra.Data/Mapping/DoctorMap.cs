using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SRCM.Domain.Entities;
using SRCM.Domain.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Infra.Data.Mapping
{
    public class DoctorMap : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.ToTable("Doctor");
            builder.Property(appsch => appsch.Name).HasMaxLength(250).IsRequired();
            builder.Property(appsch => appsch.Cpf).HasMaxLength(11).IsRequired();
            builder.Property(appsch => appsch.Crm).HasMaxLength(10).IsRequired();
            builder.Property(appsch => appsch.Email).HasMaxLength(100).IsRequired();
            builder.Property(appsch => appsch.AddressId).IsRequired();
            builder.Property(appsch => appsch.Birthday).IsRequired();
            builder.Property(appsch => appsch.Specialty).IsRequired();
            builder.HasKey(appsch => appsch.Id);
        }
    }
}
