using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class UpdatePropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShopQuantity",
                table: "Products",
                newName: "WarehouseQuantity");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AFjAqrqaBWts6YFCpo1bBylMW/qKg8Mfsz2/Et971BbdVjDrebKb0YVAl1eqVplx+g==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WarehouseQuantity",
                table: "Products",
                newName: "ShopQuantity");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AGn2P27ew3CyI5WoFTSt0ILsF79L6tqGz57HaXOtE8IW+22roNforv+KkDidWcGW7g==");
        }
    }
}
