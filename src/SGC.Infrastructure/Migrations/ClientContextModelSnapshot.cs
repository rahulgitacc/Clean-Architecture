﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SGC.Infrastructure.Data;

namespace SGC.Infrastructure.Migrations
{
    [DbContext(typeof(ClientContext))]
    partial class ClientContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SGC.ApplicationCore.Entity.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<int>("ClientId");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("PublicPlace")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Reference")
                        .HasColumnType("varchar(400)");

                    b.HasKey("AddressId");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("SGC.ApplicationCore.Entity.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("ClientId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("SGC.ApplicationCore.Entity.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Telephone")
                        .HasColumnType("varchar(15)");

                    b.HasKey("ContactId");

                    b.HasIndex("ClientId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("SGC.ApplicationCore.Entity.CustomerService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<int>("ProfessionId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ProfessionId");

                    b.ToTable("CustomerServices");
                });

            modelBuilder.Entity("SGC.ApplicationCore.Entity.Profession", b =>
                {
                    b.Property<int>("ProfessionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CBO")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.HasKey("ProfessionId");

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("SGC.ApplicationCore.Entity.Address", b =>
                {
                    b.HasOne("SGC.ApplicationCore.Entity.Client", "Client")
                        .WithOne("Address")
                        .HasForeignKey("SGC.ApplicationCore.Entity.Address", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGC.ApplicationCore.Entity.Contact", b =>
                {
                    b.HasOne("SGC.ApplicationCore.Entity.Client", "Client")
                        .WithMany("Contacts")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGC.ApplicationCore.Entity.CustomerService", b =>
                {
                    b.HasOne("SGC.ApplicationCore.Entity.Client", "Client")
                        .WithMany("CustomerServices")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SGC.ApplicationCore.Entity.Profession", "Profession")
                        .WithMany("CustomerServices")
                        .HasForeignKey("ProfessionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
