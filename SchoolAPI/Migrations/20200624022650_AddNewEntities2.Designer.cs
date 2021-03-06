﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SchoolAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20200624022650_AddNewEntities2")]
    partial class AddNewEntities2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.CourseSection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CourseSectionID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasMaxLength(60);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CourseSection");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(3564),
                            EndDate = new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(2932),
                            StartDate = new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(1815),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(4093)
                        },
                        new
                        {
                            Id = new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(5149),
                            EndDate = new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(5140),
                            StartDate = new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(5116),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(5158)
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(5174),
                            EndDate = new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(5172),
                            StartDate = new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(5170),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(5176)
                        });
                });

            modelBuilder.Entity("Entities.Models.Courses", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CourseID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                            CourseName = "Web Systems Development",
                            CreatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 765, DateTimeKind.Local).AddTicks(4542),
                            Description = "Learn version control and apply the concepts to building an API using Python, Docker, and Pycharm. ",
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 765, DateTimeKind.Local).AddTicks(5370)
                        },
                        new
                        {
                            Id = new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                            CourseName = "	Web Services and Middleware",
                            CreatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 765, DateTimeKind.Local).AddTicks(5971),
                            Description = "Learn how to build an ASP .NET Web using C# and github.",
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 765, DateTimeKind.Local).AddTicks(6000)
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            CourseName = "	Enterprise Database Management",
                            CreatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 765, DateTimeKind.Local).AddTicks(6017),
                            Description = "Students will obtain a conceptual foundation of database design and explore the implications for organizational database usage.",
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 765, DateTimeKind.Local).AddTicks(6020)
                        });
                });

            modelBuilder.Entity("Entities.Models.Organization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OrgName")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            OrgName = "xyz org"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            OrgName = "lmnop org"
                        });
                });

            modelBuilder.Entity("Entities.Models.SectionEnrollManage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SectionEnrollID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasMaxLength(60);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SectionEnrollManages");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(2775),
                            EndDate = new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(2227),
                            StartDate = new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(1305),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3337)
                        },
                        new
                        {
                            Id = new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3811),
                            EndDate = new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3804),
                            StartDate = new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3787),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3818)
                        },
                        new
                        {
                            Id = new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3831),
                            EndDate = new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3829),
                            StartDate = new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3827),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3833)
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CourseSectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SectionEnrollManageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("CourseID");

                    b.HasIndex("CourseSectionId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("SectionEnrollManageId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            CourseID = new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                            OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            UserName = "sderosa"
                        },
                        new
                        {
                            Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            CourseID = new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                            OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            UserName = "zwaltz"
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            CourseID = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            UserName = "stussel"
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.HasOne("Entities.Models.Courses", "Courses")
                        .WithMany("Users")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.CourseSection", null)
                        .WithMany("Users")
                        .HasForeignKey("CourseSectionId");

                    b.HasOne("Entities.Models.Organization", "Organization")
                        .WithMany("Users")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.SectionEnrollManage", null)
                        .WithMany("Users")
                        .HasForeignKey("SectionEnrollManageId");
                });
#pragma warning restore 612, 618
        }
    }
}
