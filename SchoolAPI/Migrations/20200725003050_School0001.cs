using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class School0001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 12, 23, 718, DateTimeKind.Local).AddTicks(4936), new DateTime(2020, 7, 24, 0, 12, 23, 718, DateTimeKind.Local).AddTicks(4933), new DateTime(2020, 7, 24, 0, 12, 23, 718, DateTimeKind.Local).AddTicks(4930), new DateTime(2020, 7, 24, 0, 12, 23, 718, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 12, 23, 718, DateTimeKind.Local).AddTicks(3783), new DateTime(2020, 7, 24, 0, 12, 23, 718, DateTimeKind.Local).AddTicks(3261), new DateTime(2020, 7, 24, 0, 12, 23, 718, DateTimeKind.Local).AddTicks(2695), new DateTime(2020, 7, 24, 0, 12, 23, 718, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 12, 23, 718, DateTimeKind.Local).AddTicks(4906), new DateTime(2020, 7, 24, 0, 12, 23, 718, DateTimeKind.Local).AddTicks(4894), new DateTime(2020, 7, 24, 0, 12, 23, 718, DateTimeKind.Local).AddTicks(4875), new DateTime(2020, 7, 24, 0, 12, 23, 718, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 12, 23, 717, DateTimeKind.Local).AddTicks(7820), new DateTime(2020, 7, 24, 0, 12, 23, 717, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 12, 23, 717, DateTimeKind.Local).AddTicks(6686), new DateTime(2020, 7, 24, 0, 12, 23, 717, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 12, 23, 717, DateTimeKind.Local).AddTicks(7788), new DateTime(2020, 7, 24, 0, 12, 23, 717, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 12, 23, 719, DateTimeKind.Local).AddTicks(8631), new DateTime(2020, 7, 24, 0, 12, 23, 719, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 12, 23, 720, DateTimeKind.Local).AddTicks(642), new DateTime(2020, 7, 24, 0, 12, 23, 720, DateTimeKind.Local).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 12, 23, 720, DateTimeKind.Local).AddTicks(692), new DateTime(2020, 7, 24, 0, 12, 23, 720, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 12, 23, 719, DateTimeKind.Local).AddTicks(958), new DateTime(2020, 7, 24, 0, 12, 23, 719, DateTimeKind.Local).AddTicks(423), new DateTime(2020, 7, 24, 0, 12, 23, 718, DateTimeKind.Local).AddTicks(9757), new DateTime(2020, 7, 24, 0, 12, 23, 719, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 12, 23, 719, DateTimeKind.Local).AddTicks(2020), new DateTime(2020, 7, 24, 0, 12, 23, 719, DateTimeKind.Local).AddTicks(2017), new DateTime(2020, 7, 24, 0, 12, 23, 719, DateTimeKind.Local).AddTicks(2014), new DateTime(2020, 7, 24, 0, 12, 23, 719, DateTimeKind.Local).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 12, 23, 719, DateTimeKind.Local).AddTicks(1991), new DateTime(2020, 7, 24, 0, 12, 23, 719, DateTimeKind.Local).AddTicks(1981), new DateTime(2020, 7, 24, 0, 12, 23, 719, DateTimeKind.Local).AddTicks(1964), new DateTime(2020, 7, 24, 0, 12, 23, 719, DateTimeKind.Local).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 12, 23, 716, DateTimeKind.Local).AddTicks(9850), new DateTime(2020, 7, 24, 0, 12, 23, 716, DateTimeKind.Local).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 12, 23, 716, DateTimeKind.Local).AddTicks(7598), new DateTime(2020, 7, 24, 0, 12, 23, 716, DateTimeKind.Local).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 12, 23, 716, DateTimeKind.Local).AddTicks(9789), new DateTime(2020, 7, 24, 0, 12, 23, 716, DateTimeKind.Local).AddTicks(9811) });
        }
    }
}
