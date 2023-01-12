using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewPropertiesFileId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FileId",
                table: "ModelDetails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AMmmph7L7nBaZREmnoEHDAWJ6q1e1mYHROJutwnR9tmQWxs6IlFtgKlBse9brhc3tA==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileId",
                table: "ModelDetails");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AKTzjXdkjwfV7898SM5qPSf0frHItyH2Nn9eGnQuKJkEMB5iAufx+h3e6Y8SdnvTVg==");
        }
    }
}
