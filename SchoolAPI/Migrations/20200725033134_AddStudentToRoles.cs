using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class AddStudentToRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "eecfe483-6e91-4868-9181-68006e2f3545", "5251312d-0555-4838-9a92-6b1883950ace", "Manager", "MANAGER" },
                    { "53d5b391-5438-4a3f-a901-7cdf8ce9acfe", "a0b45dd2-1845-4acf-9b99-f520a508ae24", "Administrator", "ADMINISTRATOR" },
                    { "eeb891b9-3373-4109-a81e-706056124c7b", "04d473c4-4566-4904-a00e-178bc36cb443", "Student", "STUDENT" }
                });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(9634), new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(9630), new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(9627), new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(8437), new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(7845), new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(7199), new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(9600), new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(9587), new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(9567), new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(1510), new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(264), new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(1459), new DateTime(2020, 7, 24, 23, 31, 33, 833, DateTimeKind.Local).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 31, 33, 835, DateTimeKind.Local).AddTicks(5076), new DateTime(2020, 7, 24, 23, 31, 33, 835, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 31, 33, 835, DateTimeKind.Local).AddTicks(7473), new DateTime(2020, 7, 24, 23, 31, 33, 835, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 31, 33, 835, DateTimeKind.Local).AddTicks(7541), new DateTime(2020, 7, 24, 23, 31, 33, 835, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 31, 33, 834, DateTimeKind.Local).AddTicks(6668), new DateTime(2020, 7, 24, 23, 31, 33, 834, DateTimeKind.Local).AddTicks(6094), new DateTime(2020, 7, 24, 23, 31, 33, 834, DateTimeKind.Local).AddTicks(5420), new DateTime(2020, 7, 24, 23, 31, 33, 834, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 31, 33, 834, DateTimeKind.Local).AddTicks(7881), new DateTime(2020, 7, 24, 23, 31, 33, 834, DateTimeKind.Local).AddTicks(7877), new DateTime(2020, 7, 24, 23, 31, 33, 834, DateTimeKind.Local).AddTicks(7874), new DateTime(2020, 7, 24, 23, 31, 33, 834, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 31, 33, 834, DateTimeKind.Local).AddTicks(7846), new DateTime(2020, 7, 24, 23, 31, 33, 834, DateTimeKind.Local).AddTicks(7835), new DateTime(2020, 7, 24, 23, 31, 33, 834, DateTimeKind.Local).AddTicks(7813), new DateTime(2020, 7, 24, 23, 31, 33, 834, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 31, 33, 832, DateTimeKind.Local).AddTicks(3359), new DateTime(2020, 7, 24, 23, 31, 33, 832, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 31, 33, 832, DateTimeKind.Local).AddTicks(758), new DateTime(2020, 7, 24, 23, 31, 33, 832, DateTimeKind.Local).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 31, 33, 832, DateTimeKind.Local).AddTicks(3292), new DateTime(2020, 7, 24, 23, 31, 33, 832, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 20, 30, 49, 829, DateTimeKind.Local).AddTicks(4517), new DateTime(2020, 7, 24, 20, 30, 49, 829, DateTimeKind.Local).AddTicks(4514), new DateTime(2020, 7, 24, 20, 30, 49, 829, DateTimeKind.Local).AddTicks(4511), new DateTime(2020, 7, 24, 20, 30, 49, 829, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 20, 30, 49, 829, DateTimeKind.Local).AddTicks(3340), new DateTime(2020, 7, 24, 20, 30, 49, 829, DateTimeKind.Local).AddTicks(2780), new DateTime(2020, 7, 24, 20, 30, 49, 829, DateTimeKind.Local).AddTicks(2165), new DateTime(2020, 7, 24, 20, 30, 49, 829, DateTimeKind.Local).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 20, 30, 49, 829, DateTimeKind.Local).AddTicks(4485), new DateTime(2020, 7, 24, 20, 30, 49, 829, DateTimeKind.Local).AddTicks(4474), new DateTime(2020, 7, 24, 20, 30, 49, 829, DateTimeKind.Local).AddTicks(4454), new DateTime(2020, 7, 24, 20, 30, 49, 829, DateTimeKind.Local).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 20, 30, 49, 828, DateTimeKind.Local).AddTicks(6271), new DateTime(2020, 7, 24, 20, 30, 49, 828, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 20, 30, 49, 828, DateTimeKind.Local).AddTicks(4991), new DateTime(2020, 7, 24, 20, 30, 49, 828, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 20, 30, 49, 828, DateTimeKind.Local).AddTicks(6235), new DateTime(2020, 7, 24, 20, 30, 49, 828, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 20, 30, 49, 830, DateTimeKind.Local).AddTicks(8795), new DateTime(2020, 7, 24, 20, 30, 49, 830, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 20, 30, 49, 831, DateTimeKind.Local).AddTicks(1565), new DateTime(2020, 7, 24, 20, 30, 49, 831, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 20, 30, 49, 831, DateTimeKind.Local).AddTicks(1624), new DateTime(2020, 7, 24, 20, 30, 49, 831, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 20, 30, 49, 830, DateTimeKind.Local).AddTicks(1197), new DateTime(2020, 7, 24, 20, 30, 49, 830, DateTimeKind.Local).AddTicks(552), new DateTime(2020, 7, 24, 20, 30, 49, 829, DateTimeKind.Local).AddTicks(9843), new DateTime(2020, 7, 24, 20, 30, 49, 830, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 20, 30, 49, 830, DateTimeKind.Local).AddTicks(2407), new DateTime(2020, 7, 24, 20, 30, 49, 830, DateTimeKind.Local).AddTicks(2404), new DateTime(2020, 7, 24, 20, 30, 49, 830, DateTimeKind.Local).AddTicks(2401), new DateTime(2020, 7, 24, 20, 30, 49, 830, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 20, 30, 49, 830, DateTimeKind.Local).AddTicks(2375), new DateTime(2020, 7, 24, 20, 30, 49, 830, DateTimeKind.Local).AddTicks(2353), new DateTime(2020, 7, 24, 20, 30, 49, 830, DateTimeKind.Local).AddTicks(2334), new DateTime(2020, 7, 24, 20, 30, 49, 830, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 20, 30, 49, 827, DateTimeKind.Local).AddTicks(8267), new DateTime(2020, 7, 24, 20, 30, 49, 827, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 20, 30, 49, 827, DateTimeKind.Local).AddTicks(5884), new DateTime(2020, 7, 24, 20, 30, 49, 827, DateTimeKind.Local).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 20, 30, 49, 827, DateTimeKind.Local).AddTicks(8204), new DateTime(2020, 7, 24, 20, 30, 49, 827, DateTimeKind.Local).AddTicks(8227) });
        }
    }
}
