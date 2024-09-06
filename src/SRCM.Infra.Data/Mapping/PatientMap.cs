using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SRCM.Domain.Entities;

namespace SRCM.Infra.Data.Mapping
{
    public class PatientMap : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("Patient");
            builder.Property(appsch => appsch.Name).HasMaxLength(250).IsRequired();
            builder.Property(appsch => appsch.Birthday).IsRequired();
            builder.Property(appsch => appsch.CPF).HasMaxLength(11).IsRequired();
            builder.Property(appsch => appsch.Email).HasMaxLength(100).IsRequired();
            builder.Property(appsch => appsch.AddressId).IsRequired();
            builder.Property(appsch => appsch.Birthday).IsRequired();
            builder.Property(appsch => appsch.AddressId).IsRequired();

            builder.HasKey(appsch => appsch.Id);
        }
    }
}
