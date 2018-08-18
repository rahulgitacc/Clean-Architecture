using Microsoft.EntityFrameworkCore;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.Data
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Tb_Client");
        }
    }
}
