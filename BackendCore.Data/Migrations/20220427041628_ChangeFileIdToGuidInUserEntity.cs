using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class ChangeFileIdToGuidInUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "ADnP5dPgvW5QxKxlhCDDSVJjH7Xy5T3q5lP53GALhIjO91GGK4t4mA7MKw3dtiTImw==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "APelGwyJ9q4wFn85iN4h6Aa8YSb91h+iNlIq4olsVoogNV2s2Mu/aRVuCjlhCqFFbQ==");
        }
    }
}
