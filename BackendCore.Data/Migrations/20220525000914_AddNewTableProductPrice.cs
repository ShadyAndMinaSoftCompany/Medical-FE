using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class AddNewTableProductPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductPriceId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductPricingLevel",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductPrices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    QuantityAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantityNetAmountWithDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPriceWithDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VatForDiscountPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VatForDiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantityNetAmountWithDiscountAndVat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeliveryAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPriceWithDelivery = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VatForDeliveryPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VatForDeliveryAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantityNetAmountWithDeliveryAndVat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoadingAndUnloadingAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPriceWithLoadingAndUnloading = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VatForLoadingAndUnloadingPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VatForLoadingAndUnloadingAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantityNetAmountWithLoadingAndUnloadingAndVat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProfitRatioPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProfitRatioAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPriceAmountWithProfitRatio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VatForPosPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VatForPosAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductPosAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VatForOnlinePercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VatForOnlineAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductOnlineAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrices", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AEwdTFpa9WiFfQCeUmstSEMEGMU4S9gBWw7roY9BafJBqLw6JjogZRgwSYTgLXZnzA==");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductPriceId",
                table: "Products",
                column: "ProductPriceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductPrices_ProductPriceId",
                table: "Products",
                column: "ProductPriceId",
                principalTable: "ProductPrices",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductPrices_ProductPriceId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductPrices");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductPriceId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductPriceId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductPricingLevel",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AO7ZotZC4XwMyXFd5sn9iULGmgwQt2562bWogwmRKG7SN9zlEpzjWB1+PULAnhb+Ng==");
        }
    }
}
