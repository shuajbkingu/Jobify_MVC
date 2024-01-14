﻿// <auto-generated />
using Jobify.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jobify.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240107125641_addImageUrlToPuna")]
    partial class addImageUrlToPuna
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Jobify.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Backend"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Frontend"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Full-Stack"
                        });
                });

            modelBuilder.Entity("Jobify.Models.Puna", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Emri_Pozites")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kerkesat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lokacioni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pershkrimi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Punet");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmriPozites = "Full-Stack",
                            ImageUrl = "",
                            Kerkesat = "Kerkesat1",
                            Lokacioni = "Prishtine",
                            Pershkrimi = "edhe back edhe front"
                        },
                        new
                        {
                            Id = 2,
                            EmriPozites = "Administrata Nate",
                            ImageUrl = "",
                            Kerkesat = "Kerkesat2",
                            Lokacioni = "Prishtine",
                            Pershkrimi = "edhessss edhe front"
                        },
                        new
                        {
                            Id = 3,
                            EmriPozites = "Frontend",
                            ImageUrl = "",
                            Kerkesat = "Kerkesat3",
                            Lokacioni = "Vushtrri",
                            Pershkrimi = "eddhe front"
                        },
                        new
                        {
                            Id = 4,
                            EmriPozites = "Backend",
                            ImageUrl = "",
                            Kerkesat = "Kerkesat31",
                            Lokacioni = "Prishtine",
                            Pershkrimi = "edhe back "
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
