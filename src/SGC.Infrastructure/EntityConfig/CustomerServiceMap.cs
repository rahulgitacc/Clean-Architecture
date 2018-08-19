using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.EntityConfig
{
    public class CustomerServiceMap : IEntityTypeConfiguration<CustomerService>
    {
        public void Configure(EntityTypeBuilder<CustomerService> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Client)
                .WithMany(c => c.CustomerServices)
                .HasForeignKey(c => c.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Profession)
                .WithMany(c => c.CustomerServices)
                .HasForeignKey(c => c.ProfessionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
