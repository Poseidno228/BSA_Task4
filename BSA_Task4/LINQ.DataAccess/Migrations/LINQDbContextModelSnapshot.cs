﻿// <auto-generated />
using System;
using LINQ.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LINQ.DataAccess.Migrations
{
    [DbContext(typeof(LINQDbContext))]
    partial class LINQDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LINQ.DataAccess.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("TeamId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            CreatedAt = new DateTime(2021, 7, 10, 12, 48, 45, 433, DateTimeKind.Local).AddTicks(3047),
                            Deadline = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Stroika",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 3,
                            CreatedAt = new DateTime(2021, 7, 10, 12, 48, 45, 433, DateTimeKind.Local).AddTicks(3374),
                            Deadline = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Zavod",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            CreatedAt = new DateTime(2021, 7, 10, 12, 48, 45, 433, DateTimeKind.Local).AddTicks(3387),
                            Deadline = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Doroga",
                            TeamId = 3
                        });
                });

            modelBuilder.Entity("LINQ.DataAccess.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FinishedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("PerformerId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PerformerId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 7, 10, 12, 48, 45, 433, DateTimeKind.Local).AddTicks(4287),
                            Name = "Chinit dorogu",
                            PerformerId = 6,
                            ProjectId = 3,
                            State = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 7, 10, 12, 48, 45, 433, DateTimeKind.Local).AddTicks(4605),
                            Name = "Stroit dorogu",
                            PerformerId = 6,
                            ProjectId = 3,
                            State = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 7, 10, 12, 48, 45, 433, DateTimeKind.Local).AddTicks(4617),
                            Name = "Rabotat na zavode",
                            PerformerId = 4,
                            ProjectId = 2,
                            State = 0
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2021, 7, 10, 12, 48, 45, 433, DateTimeKind.Local).AddTicks(4621),
                            Name = "Stroit doma",
                            PerformerId = 4,
                            ProjectId = 1,
                            State = 0
                        });
                });

            modelBuilder.Entity("LINQ.DataAccess.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 7, 10, 12, 48, 45, 428, DateTimeKind.Local).AddTicks(5723),
                            Name = "Bavarija"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 7, 10, 12, 48, 45, 433, DateTimeKind.Local).AddTicks(546),
                            Name = "Stroiteli"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 7, 10, 12, 48, 45, 433, DateTimeKind.Local).AddTicks(597),
                            Name = "Svarihciki"
                        });
                });

            modelBuilder.Entity("LINQ.DataAccess.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Dave",
                            RegisteredAt = new DateTime(2021, 7, 10, 12, 48, 45, 433, DateTimeKind.Local).AddTicks(1661),
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cristian",
                            RegisteredAt = new DateTime(2021, 7, 10, 12, 48, 45, 433, DateTimeKind.Local).AddTicks(2023),
                            TeamId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ronald",
                            RegisteredAt = new DateTime(2021, 7, 10, 12, 48, 45, 433, DateTimeKind.Local).AddTicks(2036),
                            TeamId = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Anna",
                            RegisteredAt = new DateTime(2021, 7, 10, 12, 48, 45, 433, DateTimeKind.Local).AddTicks(2040),
                            TeamId = 3
                        },
                        new
                        {
                            Id = 5,
                            Name = "Steve",
                            RegisteredAt = new DateTime(2021, 7, 10, 12, 48, 45, 433, DateTimeKind.Local).AddTicks(2044),
                            TeamId = 3
                        },
                        new
                        {
                            Id = 6,
                            Name = "Roshar",
                            RegisteredAt = new DateTime(2021, 7, 10, 12, 48, 45, 433, DateTimeKind.Local).AddTicks(2054),
                            TeamId = 3
                        });
                });

            modelBuilder.Entity("LINQ.DataAccess.Models.Project", b =>
                {
                    b.HasOne("LINQ.DataAccess.Models.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LINQ.DataAccess.Models.Team", null)
                        .WithMany("Projects")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LINQ.DataAccess.Models.Task", b =>
                {
                    b.HasOne("LINQ.DataAccess.Models.User", "User")
                        .WithMany("Tasks")
                        .HasForeignKey("PerformerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LINQ.DataAccess.Models.Project", null)
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LINQ.DataAccess.Models.User", b =>
                {
                    b.HasOne("LINQ.DataAccess.Models.Team", null)
                        .WithMany("Users")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("LINQ.DataAccess.Models.Project", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("LINQ.DataAccess.Models.Team", b =>
                {
                    b.Navigation("Projects");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("LINQ.DataAccess.Models.User", b =>
                {
                    b.Navigation("Projects");

                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
