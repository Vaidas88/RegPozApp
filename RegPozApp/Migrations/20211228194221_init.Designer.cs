﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegPozApp.Data;

namespace RegPozApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211228194221_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RegPozApp.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Features");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Reikia atlikti rangos darbus"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Rangos darbus atliks"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Verslo klientas"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "Skaičiavimo metodas"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "Svarbus klientas"
                        });
                });

            modelBuilder.Entity("RegPozApp.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FeatureId1")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FeatureId1");

                    b.ToTable("Values");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Taip"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Ne"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Metinis rangovas"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "Metinis subrangovas"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "Senas rangovas"
                        },
                        new
                        {
                            Id = 6,
                            IsDeleted = false,
                            Name = "Naujas rangovas"
                        },
                        new
                        {
                            Id = 7,
                            IsDeleted = false,
                            Name = "Taip"
                        },
                        new
                        {
                            Id = 8,
                            IsDeleted = false,
                            Name = "Ne"
                        },
                        new
                        {
                            Id = 9,
                            IsDeleted = false,
                            Name = "Automatinis"
                        },
                        new
                        {
                            Id = 10,
                            IsDeleted = false,
                            Name = "Rankinis"
                        },
                        new
                        {
                            Id = 11,
                            IsDeleted = false,
                            Name = "Taip"
                        },
                        new
                        {
                            Id = 12,
                            IsDeleted = false,
                            Name = "Ne"
                        });
                });

            modelBuilder.Entity("RegPozApp.Models.Value", b =>
                {
                    b.HasOne("RegPozApp.Models.Feature", null)
                        .WithMany("Values")
                        .HasForeignKey("FeatureId1");
                });

            modelBuilder.Entity("RegPozApp.Models.Feature", b =>
                {
                    b.Navigation("Values");
                });
#pragma warning restore 612, 618
        }
    }
}