using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class AddProductHistoryRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "AEpCMP+P1SHESug0qCvrroeWceM7Tw1vGUdgt/pClBhv5wrIPfBnyob0FGGm0MPJuA==");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "AECnQsB7PRYTjxwX7gzs5iURGZGWo7crrIjggKKOD6XhghsIZbp7VXKke7atpWQzvQ==");
        }
    }
}
