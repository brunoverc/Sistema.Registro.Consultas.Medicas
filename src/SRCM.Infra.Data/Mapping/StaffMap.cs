using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SRCM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Infra.Data.Mapping
{
    public class StaffMap : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.ToTable("Staff");
            builder.Property(appsch => appsch.Name).HasMaxLength(250).IsRequired();
            builder.Property(appsch => appsch.Birthday).IsRequired();
            builder.Property(appsch => appsch.Cpf).HasMaxLength(11).IsRequired();
            builder.Property(appsch => appsch.CarteiraTrabalho).HasMaxLength(10).IsRequired();
            builder.Property(appsch => appsch.Email).HasMaxLength(100).IsRequired();
            builder.Property(appsch => appsch.AddressId).IsRequired();

            builder.HasKey(appsch => appsch.Id);
        }
    }
}
