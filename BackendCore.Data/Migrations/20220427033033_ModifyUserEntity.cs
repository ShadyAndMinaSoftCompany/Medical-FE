using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class ModifyUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NationalId",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "Users",
                newName: "FileId");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "Users",
                newName: "Country");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                columns: new[] { "Country", "FileId", "Name", "Password" },
                values: new object[] { null, null, "Admin", "AFWSJO65XaTSLiMYu/cCShMNSoHsjKW1MG7lWqWn8WFu754xP3tSaXm6J3X9ka3/MQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "NationalId");

            migrationBuilder.RenameColumn(
                name: "FileId",
                table: "Users",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Users",
                newName: "NameAr");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                columns: new[] { "NameAr", "NameEn", "NationalId", "Password" },
                values: new object[] { "مدير", "Admin", null, "AGu3omGgWyYUgf3SlRfSXX7phj/ZX1KB1jsUqqfN+TxumcRJrCZN0jWvxQuuBuZiLw==" });
        }
    }
}
