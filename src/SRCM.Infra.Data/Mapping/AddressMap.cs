using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SRCM.Domain.Entities;

namespace SRCM.Infra.Data.Mapping
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");
            builder.Property(address => address.Street).HasMaxLength(100).IsRequired();
            builder.Property(address => address.Number).HasMaxLength(5);
            builder.Property(address => address.Complement).HasMaxLength(150);
            builder.Property(address => address.Neighborhood).HasMaxLength(50).IsRequired();
            builder.Property(address => address.PostalCode).HasMaxLength(9).IsRequired();
            builder.Property(address => address.City).HasMaxLength(25).IsRequired();
            builder.Property(address => address.State).HasMaxLength(2).IsRequired();

            builder.HasKey(address => address.Id);
        }
    }
}
