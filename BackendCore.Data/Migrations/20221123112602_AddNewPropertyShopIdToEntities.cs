using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class AddNewPropertyShopIdToEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ShopId",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ShopId",
                table: "CashersCashHand",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AKt/707a5yBwJD++0K9u0ln1mlCY80p6aWXaFC6Fixwt96FPcqzN9vmrFf/mXnFQbg==");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ShopId",
                table: "Transactions",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_CashersCashHand_ShopId",
                table: "CashersCashHand",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_CashersCashHand_Shops_ShopId",
                table: "CashersCashHand",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Shops_ShopId",
                table: "Transactions",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CashersCashHand_Shops_ShopId",
                table: "CashersCashHand");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Shops_ShopId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_ShopId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_CashersCashHand_ShopId",
                table: "CashersCashHand");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "CashersCashHand");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AKKq6+CS7JdMI+Ma1rgqg+5Ffkywh/N/kyx0omIaXorg8T+vupfJgtgMvScTCT7S6w==");
        }
    }
}
