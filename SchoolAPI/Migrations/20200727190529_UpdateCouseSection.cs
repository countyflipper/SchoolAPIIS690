using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class UpdateCouseSection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "SectionID",
                table: "CourseSection",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CourseSection",
                nullable: true);

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
                columns: new[] { "CreatedDate", "EndDate", "SectionID", "StartDate", "UpdatedDate", "UserId" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(389), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(387), "D03", new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(384), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(391), "" });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "SectionID", "StartDate", "UpdatedDate", "UserId" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 753, DateTimeKind.Local).AddTicks(8989), new DateTime(2020, 7, 27, 15, 5, 28, 753, DateTimeKind.Local).AddTicks(8540), "D01", new DateTime(2020, 7, 27, 15, 5, 28, 753, DateTimeKind.Local).AddTicks(8063), new DateTime(2020, 7, 27, 15, 5, 28, 753, DateTimeKind.Local).AddTicks(9447), "80abbca8-664d-4b20-b5de-024705497d4a" });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "SectionID", "StartDate", "UpdatedDate", "UserId" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(345), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(337), "D02", new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(319), new DateTime(2020, 7, 27, 15, 5, 28, 754, DateTimeKind.Local).AddTicks(351), "" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "SectionID",
                table: "CourseSection");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CourseSection");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
