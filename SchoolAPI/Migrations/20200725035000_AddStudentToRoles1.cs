using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class AddStudentToRoles1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53d5b391-5438-4a3f-a901-7cdf8ce9acfe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eeb891b9-3373-4109-a81e-706056124c7b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eecfe483-6e91-4868-9181-68006e2f3545");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "87e9108c-530d-4e0b-a042-0795b41331e6", "82ce2948-89ba-495d-9d7c-b565ed06a63c", "Manager", "MANAGER" },
                    { "37b8d30a-d737-4031-b256-08ad1797f7d1", "f1e9e684-3aaa-4b34-9a9e-61e6ed72eafa", "Administrator", "ADMINISTRATOR" },
                    { "1373701b-811c-45d7-9253-bad32a3d2d7d", "c981e412-bf2c-4e55-944f-994df3992068", "Student", "STUDENT" }
                });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 49, 59, 818, DateTimeKind.Local).AddTicks(5089), new DateTime(2020, 7, 24, 23, 49, 59, 818, DateTimeKind.Local).AddTicks(5087), new DateTime(2020, 7, 24, 23, 49, 59, 818, DateTimeKind.Local).AddTicks(5085), new DateTime(2020, 7, 24, 23, 49, 59, 818, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 49, 59, 818, DateTimeKind.Local).AddTicks(4153), new DateTime(2020, 7, 24, 23, 49, 59, 818, DateTimeKind.Local).AddTicks(3505), new DateTime(2020, 7, 24, 23, 49, 59, 818, DateTimeKind.Local).AddTicks(3066), new DateTime(2020, 7, 24, 23, 49, 59, 818, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 49, 59, 818, DateTimeKind.Local).AddTicks(5068), new DateTime(2020, 7, 24, 23, 49, 59, 818, DateTimeKind.Local).AddTicks(5061), new DateTime(2020, 7, 24, 23, 49, 59, 818, DateTimeKind.Local).AddTicks(5042), new DateTime(2020, 7, 24, 23, 49, 59, 818, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 49, 59, 817, DateTimeKind.Local).AddTicks(9351), new DateTime(2020, 7, 24, 23, 49, 59, 817, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 49, 59, 817, DateTimeKind.Local).AddTicks(8451), new DateTime(2020, 7, 24, 23, 49, 59, 817, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 49, 59, 817, DateTimeKind.Local).AddTicks(9317), new DateTime(2020, 7, 24, 23, 49, 59, 817, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 49, 59, 819, DateTimeKind.Local).AddTicks(7067), new DateTime(2020, 7, 24, 23, 49, 59, 819, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 49, 59, 819, DateTimeKind.Local).AddTicks(8882), new DateTime(2020, 7, 24, 23, 49, 59, 819, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 49, 59, 819, DateTimeKind.Local).AddTicks(8919), new DateTime(2020, 7, 24, 23, 49, 59, 819, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 49, 59, 819, DateTimeKind.Local).AddTicks(449), new DateTime(2020, 7, 24, 23, 49, 59, 818, DateTimeKind.Local).AddTicks(9998), new DateTime(2020, 7, 24, 23, 49, 59, 818, DateTimeKind.Local).AddTicks(9500), new DateTime(2020, 7, 24, 23, 49, 59, 819, DateTimeKind.Local).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 49, 59, 819, DateTimeKind.Local).AddTicks(1625), new DateTime(2020, 7, 24, 23, 49, 59, 819, DateTimeKind.Local).AddTicks(1623), new DateTime(2020, 7, 24, 23, 49, 59, 819, DateTimeKind.Local).AddTicks(1620), new DateTime(2020, 7, 24, 23, 49, 59, 819, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 49, 59, 819, DateTimeKind.Local).AddTicks(1596), new DateTime(2020, 7, 24, 23, 49, 59, 819, DateTimeKind.Local).AddTicks(1584), new DateTime(2020, 7, 24, 23, 49, 59, 819, DateTimeKind.Local).AddTicks(1561), new DateTime(2020, 7, 24, 23, 49, 59, 819, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 49, 59, 817, DateTimeKind.Local).AddTicks(3886), new DateTime(2020, 7, 24, 23, 49, 59, 817, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 49, 59, 817, DateTimeKind.Local).AddTicks(1901), new DateTime(2020, 7, 24, 23, 49, 59, 817, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 24, 23, 49, 59, 817, DateTimeKind.Local).AddTicks(3840), new DateTime(2020, 7, 24, 23, 49, 59, 817, DateTimeKind.Local).AddTicks(3863) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1373701b-811c-45d7-9253-bad32a3d2d7d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37b8d30a-d737-4031-b256-08ad1797f7d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87e9108c-530d-4e0b-a042-0795b41331e6");

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
        }
    }
}
