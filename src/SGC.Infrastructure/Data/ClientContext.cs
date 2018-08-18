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
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Contact>().ToTable("Contact");

            #region Client table configuration

            modelBuilder.Entity<Client>().Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Client>().Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .IsRequired();

            #endregion

            #region Contact table configuration

            modelBuilder.Entity<Contact>().Property(c => c.Name)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Contact>().Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Contact>().Property(c => c.Telephone)
                .HasColumnType("varchar(15)");

            #endregion
        }
    }
}
