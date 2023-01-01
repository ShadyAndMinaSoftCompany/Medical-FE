using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class RemoveProductHistoryRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsHistories_Products_ProducId",
                table: "ProductsHistories");

            migrationBuilder.DropIndex(
                name: "IX_ProductsHistories_ProducId",
                table: "ProductsHistories");

            migrationBuilder.DropColumn(
                name: "ProducId",
                table: "ProductsHistories");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "AECnQsB7PRYTjxwX7gzs5iURGZGWo7crrIjggKKOD6XhghsIZbp7VXKke7atpWQzvQ==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProducId",
                table: "ProductsHistories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "ACVhhq3wbu5MC26p0YN29p1e8TxannVDebb/hN0q2nej48BaKNis6XWHdfouOdceJw==");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsHistories_ProducId",
                table: "ProductsHistories",
                column: "ProducId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsHistories_Products_ProducId",
                table: "ProductsHistories",
                column: "ProducId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
