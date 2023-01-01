using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class AddShopIdToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ShopId",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AOqyd77IDIhPwEz8Yfx62sm4vLVEyRYIPgH+c0BCt5U5Xhmp5kdFYTF23EseJIFH8A==");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ShopId",
                table: "Categories",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Shops_ShopId",
                table: "Categories",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Shops_ShopId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ShopId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AFjAqrqaBWts6YFCpo1bBylMW/qKg8Mfsz2/Et971BbdVjDrebKb0YVAl1eqVplx+g==");
        }
    }
}
