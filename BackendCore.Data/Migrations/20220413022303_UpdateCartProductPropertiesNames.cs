using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class UpdateCartProductPropertiesNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProducts_Products_ProductId",
                table: "CartProducts");

            migrationBuilder.DropIndex(
                name: "IX_CartProducts_ProductId",
                table: "CartProducts");

            migrationBuilder.DropColumn(
                name: "ProducId",
                table: "CartProducts");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "CartProducts");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "ALLhF0Z1tfCeVH1Qh/ZrsfnixGEtZve4duE2iGivo12aVjmkskM7rXoNUkkNOv51Sg==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProducId",
                table: "CartProducts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "CartProducts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "AAvJ21Tt6duTEROxun/Sg9UgtSeymAbJLWBY+G1qzD5vh0ig4RDktFh19tYIXbgRlw==");

            migrationBuilder.CreateIndex(
                name: "IX_CartProducts_ProductId",
                table: "CartProducts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProducts_Products_ProductId",
                table: "CartProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
