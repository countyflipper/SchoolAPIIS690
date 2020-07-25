using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class CreatingIdentityTables : Migration
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

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(1772), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(1770), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(1768), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(819), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(362), new DateTime(2020, 7, 23, 20, 26, 49, 130, DateTimeKind.Local).AddTicks(9854), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(1750), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(1743), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(1726), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 26, 49, 130, DateTimeKind.Local).AddTicks(5483), new DateTime(2020, 7, 23, 20, 26, 49, 130, DateTimeKind.Local).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 26, 49, 130, DateTimeKind.Local).AddTicks(4505), new DateTime(2020, 7, 23, 20, 26, 49, 130, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 26, 49, 130, DateTimeKind.Local).AddTicks(5454), new DateTime(2020, 7, 23, 20, 26, 49, 130, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 26, 49, 132, DateTimeKind.Local).AddTicks(3334), new DateTime(2020, 7, 23, 20, 26, 49, 132, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 26, 49, 132, DateTimeKind.Local).AddTicks(5107), new DateTime(2020, 7, 23, 20, 26, 49, 132, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 26, 49, 132, DateTimeKind.Local).AddTicks(5147), new DateTime(2020, 7, 23, 20, 26, 49, 132, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(6978), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(6520), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(6019), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(7944), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(7942), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(7940), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(7922), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(7915), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(7898), new DateTime(2020, 7, 23, 20, 26, 49, 131, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 26, 49, 129, DateTimeKind.Local).AddTicks(9334), new DateTime(2020, 7, 23, 20, 26, 49, 129, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 26, 49, 129, DateTimeKind.Local).AddTicks(7382), new DateTime(2020, 7, 23, 20, 26, 49, 129, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 26, 49, 129, DateTimeKind.Local).AddTicks(9284), new DateTime(2020, 7, 23, 20, 26, 49, 129, DateTimeKind.Local).AddTicks(9305) });

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
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(553), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(551), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(549), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(9268), new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(8833), new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(8033), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(529), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(520), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(481), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(4029), new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(3176), new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(4002), new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 845, DateTimeKind.Local).AddTicks(3245), new DateTime(2020, 7, 17, 19, 39, 59, 845, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 845, DateTimeKind.Local).AddTicks(5400), new DateTime(2020, 7, 17, 19, 39, 59, 845, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 845, DateTimeKind.Local).AddTicks(5441), new DateTime(2020, 7, 17, 19, 39, 59, 845, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(5203), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(4807), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(4373), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(6088), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(6086), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(6084), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(6068), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(6061), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(6044), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 842, DateTimeKind.Local).AddTicks(8352), new DateTime(2020, 7, 17, 19, 39, 59, 842, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 842, DateTimeKind.Local).AddTicks(6019), new DateTime(2020, 7, 17, 19, 39, 59, 842, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 842, DateTimeKind.Local).AddTicks(8297), new DateTime(2020, 7, 17, 19, 39, 59, 842, DateTimeKind.Local).AddTicks(8314) });
        }
    }
}
