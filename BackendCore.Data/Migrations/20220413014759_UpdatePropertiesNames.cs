using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class UpdatePropertiesNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProducts_Products_ProducId",
                table: "CartProducts");

            migrationBuilder.DropIndex(
                name: "IX_CartProducts_ProducId",
                table: "CartProducts");

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
                value: "AL+fMwRezDEI+Afi4Z/RtGA5krVrJ6R0kaFBxyukNoatyDMGl0J9fxSomCM1vKf/EA==");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProducts_Products_ProductId",
                table: "CartProducts");

            migrationBuilder.DropIndex(
                name: "IX_CartProducts_ProductId",
                table: "CartProducts");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "CartProducts");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "ACrtq8KOipH2m5WwqSLcWjTGiRt+TgCXimTVXYCLwH2xJBkEmPtSE+yzj1kOMbzVfg==");

            migrationBuilder.CreateIndex(
                name: "IX_CartProducts_ProducId",
                table: "CartProducts",
                column: "ProducId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProducts_Products_ProducId",
                table: "CartProducts",
                column: "ProducId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
