using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SRCM.Domain.Entities;

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
            builder.Property(appsch => appsch.Position).IsRequired();

            builder.HasKey(appsch => appsch.Id);
        }
    }
}
