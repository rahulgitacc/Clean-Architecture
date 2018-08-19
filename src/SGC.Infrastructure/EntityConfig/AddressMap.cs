using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.EntityConfig
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(a => a.Neighborhood)
                            .HasColumnType("varchar(200)")
                            .IsRequired();

            builder.Property(a => a.CEP)
                            .HasColumnType("varchar(15)")
                            .IsRequired();

            builder.Property(a => a.PublicPlace)
                            .HasColumnType("varchar(200)")
                            .IsRequired();

            builder.Property(a => a.Reference)
                            .HasColumnType("varchar(400)");
        }
    }
}
