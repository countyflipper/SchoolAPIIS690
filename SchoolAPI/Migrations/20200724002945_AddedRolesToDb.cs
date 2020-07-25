using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ff83a4b6-aa3c-4ea3-9521-164a91d33ee3", "b3f44fff-7ddf-444c-b36d-2cfad9985e62", "Manager", "MANAGER" },
                    { "f3fc3460-c142-4f9a-84a2-43993a527869", "dc273594-ff04-4aef-9314-fb7f500a0afc", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(9359), new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(9357), new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(9355), new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(8386), new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(7940), new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(7445), new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(9301), new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(9294), new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(9275), new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(3153), new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(2150), new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(3125), new DateTime(2020, 7, 23, 20, 29, 45, 179, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 29, 45, 181, DateTimeKind.Local).AddTicks(759), new DateTime(2020, 7, 23, 20, 29, 45, 181, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 29, 45, 181, DateTimeKind.Local).AddTicks(2529), new DateTime(2020, 7, 23, 20, 29, 45, 181, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 29, 45, 181, DateTimeKind.Local).AddTicks(2570), new DateTime(2020, 7, 23, 20, 29, 45, 181, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(4480), new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(4035), new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(3539), new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(5468), new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(5464), new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(5461), new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(5430), new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(5414), new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(5390), new DateTime(2020, 7, 23, 20, 29, 45, 180, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 29, 45, 178, DateTimeKind.Local).AddTicks(7069), new DateTime(2020, 7, 23, 20, 29, 45, 178, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 29, 45, 178, DateTimeKind.Local).AddTicks(5065), new DateTime(2020, 7, 23, 20, 29, 45, 178, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 20, 29, 45, 178, DateTimeKind.Local).AddTicks(7017), new DateTime(2020, 7, 23, 20, 29, 45, 178, DateTimeKind.Local).AddTicks(7037) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3fc3460-c142-4f9a-84a2-43993a527869");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff83a4b6-aa3c-4ea3-9521-164a91d33ee3");

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
        }
    }
}
