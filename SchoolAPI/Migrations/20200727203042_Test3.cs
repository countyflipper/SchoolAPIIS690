using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class Test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1de8a9c2-738f-4924-942f-f86b09f7061b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42d1b3e1-5c15-4aa1-81a5-e9e9634874c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7258f157-c2e3-43a5-9a0e-c65d73378853");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7258f157-c2e3-43a5-9a0e-c65d73378853", "58513c2d-3c30-49cc-bd43-db49faccd57b", "Manager", "MANAGER" },
                    { "1de8a9c2-738f-4924-942f-f86b09f7061b", "3bcad09b-0fb7-40af-9f24-1dcb26914882", "Administrator", "ADMINISTRATOR" },
                    { "42d1b3e1-5c15-4aa1-81a5-e9e9634874c6", "f764ca48-9d75-4113-b246-8af6f22d9395", "Student", "STUDENT" }
                });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(389), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(387), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(384), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 753, DateTimeKind.Local).AddTicks(8989), new DateTime(2020, 7, 27, 15, 5, 28, 753, DateTimeKind.Local).AddTicks(8540), new DateTime(2020, 7, 27, 15, 5, 28, 753, DateTimeKind.Local).AddTicks(8063), new DateTime(2020, 7, 27, 15, 5, 28, 753, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(345), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(337), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(319), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 753, DateTimeKind.Local).AddTicks(3139), new DateTime(2020, 7, 27, 15, 5, 28, 753, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 753, DateTimeKind.Local).AddTicks(2146), new DateTime(2020, 7, 27, 15, 5, 28, 753, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 753, DateTimeKind.Local).AddTicks(3099), new DateTime(2020, 7, 27, 15, 5, 28, 753, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 755, DateTimeKind.Local).AddTicks(1727), new DateTime(2020, 7, 27, 15, 5, 28, 755, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 755, DateTimeKind.Local).AddTicks(3555), new DateTime(2020, 7, 27, 15, 5, 28, 755, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 755, DateTimeKind.Local).AddTicks(3596), new DateTime(2020, 7, 27, 15, 5, 28, 755, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(5472), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(5024), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(4527), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(6428), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(6426), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(6424), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(6390), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(6383), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(6364), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 752, DateTimeKind.Local).AddTicks(6971), new DateTime(2020, 7, 27, 15, 5, 28, 752, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 752, DateTimeKind.Local).AddTicks(5034), new DateTime(2020, 7, 27, 15, 5, 28, 752, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 752, DateTimeKind.Local).AddTicks(6923), new DateTime(2020, 7, 27, 15, 5, 28, 752, DateTimeKind.Local).AddTicks(6947) });
        }
    }
}
