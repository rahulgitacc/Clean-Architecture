using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.EntityConfig
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.ClientId);

            builder.HasOne(c => c.Address)
                .WithOne(c => c.Client)
                .HasForeignKey<Address>(c => c.ClientId);

            builder.HasMany(c => c.Contacts)
                .WithOne(c => c.Client)
                .HasForeignKey(c => c.ClientId)
                .HasPrincipalKey(c => c.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .IsRequired();
        }
    }
}
