using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class UpdateProductPriceProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VatForPosPercentage",
                table: "ProductPrices",
                newName: "PosVatPercentage");

            migrationBuilder.RenameColumn(
                name: "VatForPosAmount",
                table: "ProductPrices",
                newName: "PosVatAmount");

            migrationBuilder.RenameColumn(
                name: "VatForOnlinePercentage",
                table: "ProductPrices",
                newName: "PosDeliveryAmount");

            migrationBuilder.RenameColumn(
                name: "VatForOnlineAmount",
                table: "ProductPrices",
                newName: "OnlineVatPercentage");

            migrationBuilder.RenameColumn(
                name: "ProductPosAmount",
                table: "ProductPrices",
                newName: "OnlineVatAmount");

            migrationBuilder.RenameColumn(
                name: "ProductOnlineAmount",
                table: "ProductPrices",
                newName: "OnlineDeliveryAmount");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "ABOBBHRDS+TgdeJZrKqLejriIBYMqyrQzKVUBo4AwgdVlv7FU67/RPR87LSkYQgyPw==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PosVatPercentage",
                table: "ProductPrices",
                newName: "VatForPosPercentage");

            migrationBuilder.RenameColumn(
                name: "PosVatAmount",
                table: "ProductPrices",
                newName: "VatForPosAmount");

            migrationBuilder.RenameColumn(
                name: "PosDeliveryAmount",
                table: "ProductPrices",
                newName: "VatForOnlinePercentage");

            migrationBuilder.RenameColumn(
                name: "OnlineVatPercentage",
                table: "ProductPrices",
                newName: "VatForOnlineAmount");

            migrationBuilder.RenameColumn(
                name: "OnlineVatAmount",
                table: "ProductPrices",
                newName: "ProductPosAmount");

            migrationBuilder.RenameColumn(
                name: "OnlineDeliveryAmount",
                table: "ProductPrices",
                newName: "ProductOnlineAmount");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AEwdTFpa9WiFfQCeUmstSEMEGMU4S9gBWw7roY9BafJBqLw6JjogZRgwSYTgLXZnzA==");
        }
    }
}
