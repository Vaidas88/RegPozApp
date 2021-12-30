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
    [Migration("20211230174440_form-added")]
    partial class formadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RegPozApp.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Taip",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Ne",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Metinis rangovas",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "Metinis subrangovas",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "Senas rangovas",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 6,
                            IsDeleted = false,
                            Name = "Naujas rangovas",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 7,
                            IsDeleted = false,
                            Name = "Taip",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 8,
                            IsDeleted = false,
                            Name = "Ne",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 9,
                            IsDeleted = false,
                            Name = "Automatinis",
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 10,
                            IsDeleted = false,
                            Name = "Rankinis",
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 11,
                            IsDeleted = false,
                            Name = "Taip",
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 12,
                            IsDeleted = false,
                            Name = "Ne",
                            QuestionId = 5
                        });
                });

            modelBuilder.Entity("RegPozApp.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnswerId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnswerId = 1,
                            IsDeleted = false,
                            Name = "Reikia atlikti rangos darbus"
                        },
                        new
                        {
                            Id = 2,
                            AnswerId = 3,
                            IsDeleted = false,
                            Name = "Rangos darbus atliks"
                        },
                        new
                        {
                            Id = 3,
                            AnswerId = 8,
                            IsDeleted = false,
                            Name = "Verslo klientas"
                        },
                        new
                        {
                            Id = 4,
                            AnswerId = 9,
                            IsDeleted = false,
                            Name = "Skaičiavimo metodas"
                        },
                        new
                        {
                            Id = 5,
                            AnswerId = 0,
                            IsDeleted = false,
                            Name = "Svarbus klientas"
                        });
                });

            modelBuilder.Entity("RegPozApp.Models.Answer", b =>
                {
                    b.HasOne("RegPozApp.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("RegPozApp.Models.Question", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
