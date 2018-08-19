using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.EntityConfig
{
    public class ProfessionMap : IEntityTypeConfiguration<Profession>
    {
        public void Configure(EntityTypeBuilder<Profession> builder)
        {
            builder.Property(p => p.Name)
                .HasColumnType("varchar(400)")
                .IsRequired();

            builder.Property(p => p.CBO)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnType("varchar(1000)")
                .IsRequired();
        }
    }
}
