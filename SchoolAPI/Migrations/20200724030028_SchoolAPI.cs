using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class SchoolAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 23, 0, 27, 978, DateTimeKind.Local).AddTicks(6497), new DateTime(2020, 7, 23, 23, 0, 27, 978, DateTimeKind.Local).AddTicks(6494), new DateTime(2020, 7, 23, 23, 0, 27, 978, DateTimeKind.Local).AddTicks(6490), new DateTime(2020, 7, 23, 23, 0, 27, 978, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 23, 0, 27, 978, DateTimeKind.Local).AddTicks(4269), new DateTime(2020, 7, 23, 23, 0, 27, 978, DateTimeKind.Local).AddTicks(3227), new DateTime(2020, 7, 23, 23, 0, 27, 978, DateTimeKind.Local).AddTicks(2123), new DateTime(2020, 7, 23, 23, 0, 27, 978, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 23, 0, 27, 978, DateTimeKind.Local).AddTicks(6464), new DateTime(2020, 7, 23, 23, 0, 27, 978, DateTimeKind.Local).AddTicks(6451), new DateTime(2020, 7, 23, 23, 0, 27, 978, DateTimeKind.Local).AddTicks(6427), new DateTime(2020, 7, 23, 23, 0, 27, 978, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 23, 0, 27, 977, DateTimeKind.Local).AddTicks(179), new DateTime(2020, 7, 23, 23, 0, 27, 977, DateTimeKind.Local).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 23, 0, 27, 976, DateTimeKind.Local).AddTicks(5006), new DateTime(2020, 7, 23, 23, 0, 27, 976, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 23, 0, 27, 977, DateTimeKind.Local).AddTicks(71), new DateTime(2020, 7, 23, 23, 0, 27, 977, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 23, 0, 27, 980, DateTimeKind.Local).AddTicks(6748), new DateTime(2020, 7, 23, 23, 0, 27, 980, DateTimeKind.Local).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 23, 0, 27, 980, DateTimeKind.Local).AddTicks(9594), new DateTime(2020, 7, 23, 23, 0, 27, 980, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 23, 0, 27, 980, DateTimeKind.Local).AddTicks(9664), new DateTime(2020, 7, 23, 23, 0, 27, 980, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 23, 0, 27, 979, DateTimeKind.Local).AddTicks(5959), new DateTime(2020, 7, 23, 23, 0, 27, 979, DateTimeKind.Local).AddTicks(5336), new DateTime(2020, 7, 23, 23, 0, 27, 979, DateTimeKind.Local).AddTicks(4423), new DateTime(2020, 7, 23, 23, 0, 27, 979, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 23, 0, 27, 979, DateTimeKind.Local).AddTicks(7831), new DateTime(2020, 7, 23, 23, 0, 27, 979, DateTimeKind.Local).AddTicks(7826), new DateTime(2020, 7, 23, 23, 0, 27, 979, DateTimeKind.Local).AddTicks(7813), new DateTime(2020, 7, 23, 23, 0, 27, 979, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 23, 0, 27, 979, DateTimeKind.Local).AddTicks(7731), new DateTime(2020, 7, 23, 23, 0, 27, 979, DateTimeKind.Local).AddTicks(7699), new DateTime(2020, 7, 23, 23, 0, 27, 979, DateTimeKind.Local).AddTicks(7660), new DateTime(2020, 7, 23, 23, 0, 27, 979, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 23, 0, 27, 975, DateTimeKind.Local).AddTicks(809), new DateTime(2020, 7, 23, 23, 0, 27, 975, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 23, 0, 27, 974, DateTimeKind.Local).AddTicks(6496), new DateTime(2020, 7, 23, 23, 0, 27, 974, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 23, 23, 0, 27, 975, DateTimeKind.Local).AddTicks(662), new DateTime(2020, 7, 23, 23, 0, 27, 975, DateTimeKind.Local).AddTicks(711) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
