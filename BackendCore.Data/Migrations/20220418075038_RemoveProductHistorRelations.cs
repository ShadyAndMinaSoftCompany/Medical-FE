using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class RemoveProductHistorRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsHistories_Products_ProductId",
                table: "ProductsHistories");

            migrationBuilder.DropIndex(
                name: "IX_ProductsHistories_ProductId",
                table: "ProductsHistories");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductsHistories");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "AHBi2jV14nvbbOOdu1tGQcjvNQiu2FsXnO/lcZ0ixXU9tK3iKOxN2IjwhETpzEXbjQ==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "ProductsHistories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "ANSCiGxgNi7LSLIUVz3NmUtntOZYSOtoDeMt5Zq6e5BX5ydBH1N+JYdCqOKd/b9gXg==");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsHistories_ProductId",
                table: "ProductsHistories",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsHistories_Products_ProductId",
                table: "ProductsHistories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
