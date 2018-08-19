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
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<CustomerService> CustomerServices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Contact>().ToTable("Contact");

            #region Client table configuration

            modelBuilder.Entity<Client>()
                .HasKey(c => c.ClientId);

            modelBuilder.Entity<Client>()
                .HasMany(c => c.Contacts)
                .WithOne(c => c.Client)
                .HasForeignKey(c => c.ClientId)
                .HasPrincipalKey(c => c.ClientId);

            modelBuilder.Entity<Client>().Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Client>().Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .IsRequired();

            #endregion

            #region Contact table configuration

            modelBuilder.Entity<Contact>()
                .HasOne(c => c.Client)
                .WithMany(c => c.Contacts)
                .HasForeignKey(c => c.ClientId)
                .HasPrincipalKey(c => c.ClientId);

            modelBuilder.Entity<Contact>().Property(c => c.Name)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Contact>().Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Contact>().Property(c => c.Telephone)
                .HasColumnType("varchar(15)");

            #endregion

            #region Profession table configuration

            modelBuilder.Entity<Profession>().Property(p => p.Name)
                .HasColumnType("varchar(400)")
                .IsRequired();

            modelBuilder.Entity<Profession>().Property(p => p.CBO)
                .HasColumnType("varchar(10)")
                .IsRequired();

            modelBuilder.Entity<Profession>().Property(p => p.Description)
                .HasColumnType("varchar(1000)")
                .IsRequired();

            #endregion

            #region Address table configuration

            modelBuilder.Entity<Address>().Property(a => a.Neighborhood)
                            .HasColumnType("varchar(200)")
                            .IsRequired();

            modelBuilder.Entity<Address>().Property(a => a.CEP)
                            .HasColumnType("varchar(15)")
                            .IsRequired();

            modelBuilder.Entity<Address>().Property(a => a.PublicPlace)
                            .HasColumnType("varchar(200)")
                            .IsRequired();

            modelBuilder.Entity<Address>().Property(a => a.Reference)
                            .HasColumnType("varchar(400)");

            #endregion

            #region CustomerService table configuration

            modelBuilder.Entity<CustomerService>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<CustomerService>()
                .HasOne(c => c.Client)
                .WithMany(c => c.CustomerServices)
                .HasForeignKey(c => c.ClientId);

            modelBuilder.Entity<CustomerService>()
                .HasOne(c => c.Profession)
                .WithMany(c => c.CustomerServices)
                .HasForeignKey(c => c.ProfessionId);

            #endregion

            #region Menu table configuration

            modelBuilder.Entity<Menu>()
                .HasMany(m => m.SubMenu)
                .WithOne()
                .HasForeignKey(m => m.MenuId);

            #endregion
        }
    }
}
