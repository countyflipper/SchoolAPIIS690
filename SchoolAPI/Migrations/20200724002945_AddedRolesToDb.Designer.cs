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
    [Migration("20200724002945_AddedRolesToDb")]
    partial class AddedRolesToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.CourseManagement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CourseManagementID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AssigmentID")
                        .HasColumnType("int")
                        .HasMaxLength(20);

                    b.Property<string>("AssignmentTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("CourseManagements");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c769e19d-c895-4ad0-97dc-9b497bff0d3e"),
                            AssigmentID = 0,
                            AssignmentTitle = "GitHub Tutorial.",
                            Description = "Learn the basic of GitHub."
                        },
                        new
                        {
                            Id = new Guid("c47748fb-1fa7-4745-a863-78fa91633c93"),
                            AssigmentID = 0,
                            AssignmentTitle = "Calculator",
                            Description = "Build a calculator using the basic math."
                        },
                        new
                        {
                            Id = new Guid("a12001ac-75cd-43ad-916f-79e1a8cd40f1"),
                            AssigmentID = 0,
                            AssignmentTitle = "Statistic Application",
                            Description = "Build an app that includes basic math and statistics."
                        });
                });

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
                            CreatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(8386),
                            EndDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(7940),
                            StartDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(7445),
                            UpdatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(8815)
                        },
                        new
                        {
                            Id = new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                            CreatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(9301),
                            EndDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(9294),
                            StartDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(9275),
                            UpdatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(9308)
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                            CreatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(9359),
                            EndDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(9357),
                            StartDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(9355),
                            UpdatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(9361)
                        });
                });

            modelBuilder.Entity("Entities.Models.Courses", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CourseID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

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
                            CreatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(2150),
                            Description = "Learn version control and apply the concepts to building an API using Python, Docker, and Pycharm. ",
                            UpdatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(2630)
                        },
                        new
                        {
                            Id = new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                            CourseName = "	Web Services and Middleware",
                            CreatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(3125),
                            Description = "Learn how to build an ASP .NET Web using C# and github.",
                            UpdatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(3143)
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            CourseName = "	Enterprise Database Management",
                            CreatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(3153),
                            Description = "Students will obtain a conceptual foundation of database design and explore the implications for organizational database usage.",
                            UpdatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(3155)
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

            modelBuilder.Entity("Entities.Models.SectionAssign", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SectionAssignID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AssignID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("SubmissionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsersID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SectionAssigns");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                            AssignID = "C769E19D-C895-4AD0-97DC-9B497BFF0D3E",
                            CreatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 181, DateTimeKind.Local).AddTicks(759),
                            Score = 91,
                            SubmissionText = "Please see link to assignment.",
                            UpdatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 181, DateTimeKind.Local).AddTicks(1223),
                            UsersID = "80abbca8-664d-4b20-b5de-024705497d4a"
                        },
                        new
                        {
                            Id = new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                            AssignID = "C769E19D-C895-4AD0-97DC-9B497BFF0D3E",
                            CreatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 181, DateTimeKind.Local).AddTicks(2529),
                            Score = 84,
                            SubmissionText = "Please see link to assignment.",
                            UpdatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 181, DateTimeKind.Local).AddTicks(2548),
                            UsersID = "021ca3c1-0deb-4afd-ae94-2159a8479811"
                        },
                        new
                        {
                            Id = new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                            AssignID = "C769E19D-C895-4AD0-97DC-9B497BFF0D3E",
                            CreatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 181, DateTimeKind.Local).AddTicks(2570),
                            Score = 99,
                            SubmissionText = "Please see link to assignment.",
                            UpdatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 181, DateTimeKind.Local).AddTicks(2572),
                            UsersID = "86dba8c0-d178-41e7-938c-ed49778fb52a"
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
                            CreatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(4480),
                            EndDate = new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(4035),
                            StartDate = new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(3539),
                            UpdatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(4910)
                        },
                        new
                        {
                            Id = new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                            CreatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(5430),
                            EndDate = new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(5414),
                            StartDate = new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(5390),
                            UpdatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(5442)
                        },
                        new
                        {
                            Id = new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                            CreatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(5468),
                            EndDate = new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(5464),
                            StartDate = new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(5461),
                            UpdatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(5470)
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

                    b.Property<Guid?>("CoursesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SectionEnrollManageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SystemRoleID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseSectionId");

                    b.HasIndex("CoursesId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("SectionEnrollManageId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            CourseID = new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                            CreatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 178, DateTimeKind.Local).AddTicks(5065),
                            Email = "sderosa@njit.edu",
                            OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Password = "pass123",
                            Status = "Active",
                            SystemRoleID = 2000001,
                            UpdatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 178, DateTimeKind.Local).AddTicks(5605),
                            UserName = "sderosa",
                            age = 34
                        },
                        new
                        {
                            Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            CourseID = new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                            CreatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 178, DateTimeKind.Local).AddTicks(7017),
                            Email = "zwaltz@njit.edu",
                            OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Password = "hippo87",
                            Status = "Active",
                            SystemRoleID = 3000008,
                            UpdatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 178, DateTimeKind.Local).AddTicks(7037),
                            UserName = "zwaltz",
                            age = 24
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            CourseID = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            CreatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 178, DateTimeKind.Local).AddTicks(7069),
                            Email = "stussel@njit.edu",
                            OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Password = "newyork1",
                            Status = "Active",
                            SystemRoleID = 8000007,
                            UpdatedDate = new DateTime(2020, 7, 23, 20, 29, 45, 178, DateTimeKind.Local).AddTicks(7071),
                            UserName = "stussel",
                            age = 48
                        });
                });

            modelBuilder.Entity("Entities.Models.Users", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "ff83a4b6-aa3c-4ea3-9521-164a91d33ee3",
                            ConcurrencyStamp = "b3f44fff-7ddf-444c-b36d-2cfad9985e62",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "f3fc3460-c142-4f9a-84a2-43993a527869",
                            ConcurrencyStamp = "dc273594-ff04-4aef-9314-fb7f500a0afc",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.HasOne("Entities.Models.CourseSection", null)
                        .WithMany("Users")
                        .HasForeignKey("CourseSectionId");

                    b.HasOne("Entities.Models.Courses", "Courses")
                        .WithMany()
                        .HasForeignKey("CoursesId");

                    b.HasOne("Entities.Models.Organization", "Organization")
                        .WithMany("Users")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.SectionEnrollManage", null)
                        .WithMany("Users")
                        .HasForeignKey("SectionEnrollManageId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Entities.Models.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Entities.Models.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Entities.Models.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
