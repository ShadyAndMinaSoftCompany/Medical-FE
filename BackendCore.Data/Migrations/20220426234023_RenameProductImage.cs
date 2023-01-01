using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class RenameProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrdProductImages_Products_ProductId",
                table: "PrdProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrdProductImages",
                table: "PrdProductImages");

            migrationBuilder.RenameTable(
                name: "PrdProductImages",
                newName: "ProductImages");

            migrationBuilder.RenameIndex(
                name: "IX_PrdProductImages_ProductId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "AOINeK/bxTuC1WtJ+0aBbkkpBYOjq6hUzSq+xPWPQLsuzVWT4C/I8Ik7kDAw+G1WtQ==");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages");

            migrationBuilder.RenameTable(
                name: "ProductImages",
                newName: "PrdProductImages");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductId",
                table: "PrdProductImages",
                newName: "IX_PrdProductImages_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrdProductImages",
                table: "PrdProductImages",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "AKu9dA7fif2D8sV9LxuNXtw3v5v07xYcln5BL+hgJ9WazF8Fdl7Keifd6RqaGQPm1A==");

            migrationBuilder.AddForeignKey(
                name: "FK_PrdProductImages_Products_ProductId",
                table: "PrdProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
