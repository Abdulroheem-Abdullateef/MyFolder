﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationMVC.Context;

namespace WebApplicationMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("WebApplicationMVC.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CityCode")
                        .HasColumnType("text");

                    b.Property<string>("CityName")
                        .HasColumnType("text");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Population")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("WebApplicationMVC.Entities.CityPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("PersonId");

                    b.ToTable("CityPersons");
                });

            modelBuilder.Entity("WebApplicationMVC.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CountryName")
                        .HasColumnType("text");

                    b.Property<string>("CountryPhoto")
                        .HasColumnType("text");

                    b.Property<int>("Independent")
                        .HasColumnType("int");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .HasColumnType("text");

                    b.Property<int>("SurfaceArea")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("WebApplicationMVC.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PassWord")
                        .HasColumnType("text");

                    b.Property<string>("PersonAddress")
                        .HasColumnType("text");

                    b.Property<string>("PersonPhoto")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("WebApplicationMVC.Entities.City", b =>
                {
                    b.HasOne("WebApplicationMVC.Entities.Country", "Country")
                        .WithMany("Citie")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("WebApplicationMVC.Entities.CityPerson", b =>
                {
                    b.HasOne("WebApplicationMVC.Entities.City", "City")
                        .WithMany("CityPersons")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationMVC.Entities.Person", "Person")
                        .WithMany("CityPersons")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("WebApplicationMVC.Entities.City", b =>
                {
                    b.Navigation("CityPersons");
                });

            modelBuilder.Entity("WebApplicationMVC.Entities.Country", b =>
                {
                    b.Navigation("Citie");
                });

            modelBuilder.Entity("WebApplicationMVC.Entities.Person", b =>
                {
                    b.Navigation("CityPersons");
                });
#pragma warning restore 612, 618
        }
    }
}
