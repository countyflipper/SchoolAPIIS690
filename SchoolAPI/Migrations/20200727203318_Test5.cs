using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class Test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14c8674a-58c7-4a75-a3b9-e9881ce748fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "470b8b33-4d6a-42cc-b8d5-df53aaa240cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5f1da41-3778-44cf-8561-04a4c69de4b5");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "IdentityRole");

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "IdentityRole",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "IdentityRole",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityRole",
                table: "IdentityRole",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 33, 17, 681, DateTimeKind.Local).AddTicks(5122), new DateTime(2020, 7, 27, 16, 33, 17, 681, DateTimeKind.Local).AddTicks(5120), new DateTime(2020, 7, 27, 16, 33, 17, 681, DateTimeKind.Local).AddTicks(5118), new DateTime(2020, 7, 27, 16, 33, 17, 681, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 33, 17, 681, DateTimeKind.Local).AddTicks(3716), new DateTime(2020, 7, 27, 16, 33, 17, 681, DateTimeKind.Local).AddTicks(3256), new DateTime(2020, 7, 27, 16, 33, 17, 681, DateTimeKind.Local).AddTicks(2756), new DateTime(2020, 7, 27, 16, 33, 17, 681, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 33, 17, 681, DateTimeKind.Local).AddTicks(5094), new DateTime(2020, 7, 27, 16, 33, 17, 681, DateTimeKind.Local).AddTicks(5087), new DateTime(2020, 7, 27, 16, 33, 17, 681, DateTimeKind.Local).AddTicks(5066), new DateTime(2020, 7, 27, 16, 33, 17, 681, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 33, 17, 680, DateTimeKind.Local).AddTicks(7794), new DateTime(2020, 7, 27, 16, 33, 17, 680, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 33, 17, 680, DateTimeKind.Local).AddTicks(6796), new DateTime(2020, 7, 27, 16, 33, 17, 680, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 33, 17, 680, DateTimeKind.Local).AddTicks(7741), new DateTime(2020, 7, 27, 16, 33, 17, 680, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c33786ac-5d83-40e9-a8e9-5b6aa943ce4b", "3eefaae4-5b09-450f-81bd-0d730e65f721", "Manager", "MANAGER" },
                    { "3813142f-681f-45ca-a7ad-6cfc5f6ce068", "3c34ba59-e625-42b6-acaa-9145ee18e913", "Student", "STUDENT" },
                    { "a55c4876-0364-49c2-9b60-aa06554d46d7", "2bdf9824-8f4d-4770-a7a7-de2f9e92f8de", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 33, 17, 682, DateTimeKind.Local).AddTicks(6770), new DateTime(2020, 7, 27, 16, 33, 17, 682, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 33, 17, 682, DateTimeKind.Local).AddTicks(8556), new DateTime(2020, 7, 27, 16, 33, 17, 682, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 33, 17, 682, DateTimeKind.Local).AddTicks(8609), new DateTime(2020, 7, 27, 16, 33, 17, 682, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 33, 17, 682, DateTimeKind.Local).AddTicks(264), new DateTime(2020, 7, 27, 16, 33, 17, 681, DateTimeKind.Local).AddTicks(9817), new DateTime(2020, 7, 27, 16, 33, 17, 681, DateTimeKind.Local).AddTicks(9323), new DateTime(2020, 7, 27, 16, 33, 17, 682, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 33, 17, 682, DateTimeKind.Local).AddTicks(1212), new DateTime(2020, 7, 27, 16, 33, 17, 682, DateTimeKind.Local).AddTicks(1211), new DateTime(2020, 7, 27, 16, 33, 17, 682, DateTimeKind.Local).AddTicks(1208), new DateTime(2020, 7, 27, 16, 33, 17, 682, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 33, 17, 682, DateTimeKind.Local).AddTicks(1176), new DateTime(2020, 7, 27, 16, 33, 17, 682, DateTimeKind.Local).AddTicks(1169), new DateTime(2020, 7, 27, 16, 33, 17, 682, DateTimeKind.Local).AddTicks(1153), new DateTime(2020, 7, 27, 16, 33, 17, 682, DateTimeKind.Local).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 33, 17, 680, DateTimeKind.Local).AddTicks(1769), new DateTime(2020, 7, 27, 16, 33, 17, 680, DateTimeKind.Local).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 33, 17, 679, DateTimeKind.Local).AddTicks(9631), new DateTime(2020, 7, 27, 16, 33, 17, 680, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 33, 17, 680, DateTimeKind.Local).AddTicks(1713), new DateTime(2020, 7, 27, 16, 33, 17, 680, DateTimeKind.Local).AddTicks(1739) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityRole",
                table: "IdentityRole");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3813142f-681f-45ca-a7ad-6cfc5f6ce068");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a55c4876-0364-49c2-9b60-aa06554d46d7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c33786ac-5d83-40e9-a8e9-5b6aa943ce4b");

            migrationBuilder.RenameTable(
                name: "IdentityRole",
                newName: "AspNetRoles");

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "AspNetRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    { "470b8b33-4d6a-42cc-b8d5-df53aaa240cf", "57c94600-7477-4397-8f09-f0e980769197", "Manager", "MANAGER" },
                    { "e5f1da41-3778-44cf-8561-04a4c69de4b5", "e3023b44-9df6-4ed9-881a-3f4ee62896da", "Administrator", "ADMINISTRATOR" },
                    { "14c8674a-58c7-4a75-a3b9-e9881ce748fe", "2b02d05e-611b-4988-9aaa-25b10273a46a", "Student", "STUDENT" }
                });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 30, 42, 12, DateTimeKind.Local).AddTicks(5919), new DateTime(2020, 7, 27, 16, 30, 42, 12, DateTimeKind.Local).AddTicks(5917), new DateTime(2020, 7, 27, 16, 30, 42, 12, DateTimeKind.Local).AddTicks(5915), new DateTime(2020, 7, 27, 16, 30, 42, 12, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 30, 42, 12, DateTimeKind.Local).AddTicks(4473), new DateTime(2020, 7, 27, 16, 30, 42, 12, DateTimeKind.Local).AddTicks(4029), new DateTime(2020, 7, 27, 16, 30, 42, 12, DateTimeKind.Local).AddTicks(3547), new DateTime(2020, 7, 27, 16, 30, 42, 12, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 30, 42, 12, DateTimeKind.Local).AddTicks(5893), new DateTime(2020, 7, 27, 16, 30, 42, 12, DateTimeKind.Local).AddTicks(5886), new DateTime(2020, 7, 27, 16, 30, 42, 12, DateTimeKind.Local).AddTicks(5867), new DateTime(2020, 7, 27, 16, 30, 42, 12, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 30, 42, 11, DateTimeKind.Local).AddTicks(8356), new DateTime(2020, 7, 27, 16, 30, 42, 11, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 30, 42, 11, DateTimeKind.Local).AddTicks(7354), new DateTime(2020, 7, 27, 16, 30, 42, 11, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 30, 42, 11, DateTimeKind.Local).AddTicks(8315), new DateTime(2020, 7, 27, 16, 30, 42, 11, DateTimeKind.Local).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(7346), new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(9074), new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(9113), new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(1000), new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(556), new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(56), new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(2012), new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(2010), new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(2008), new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(1973), new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(1965), new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(1944), new DateTime(2020, 7, 27, 16, 30, 42, 13, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 30, 42, 11, DateTimeKind.Local).AddTicks(2102), new DateTime(2020, 7, 27, 16, 30, 42, 11, DateTimeKind.Local).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 30, 42, 11, DateTimeKind.Local).AddTicks(142), new DateTime(2020, 7, 27, 16, 30, 42, 11, DateTimeKind.Local).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 16, 30, 42, 11, DateTimeKind.Local).AddTicks(2053), new DateTime(2020, 7, 27, 16, 30, 42, 11, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

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
    }
}
