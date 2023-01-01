using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class UpdateNamesAndRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DamageProductDeatils");

            migrationBuilder.CreateTable(
                name: "DamageProductDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalDamageProduct = table.Column<int>(type: "int", nullable: false),
                    ReasonOfDamage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageProductDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DamageProductDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "AEUhfki4uVGwbz7zYEb3h/x/+gOF2aHtXE1uNYsMpbWwe3s/3TSuY/sI6BYVmJ6yyw==");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsHistories_ProductId",
                table: "ProductsHistories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_DamageProductDetails_ProductId",
                table: "DamageProductDetails",
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

            migrationBuilder.DropTable(
                name: "DamageProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProductsHistories_ProductId",
                table: "ProductsHistories");

            migrationBuilder.CreateTable(
                name: "DamageProductDeatils",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReasonOfDamage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalDamageProduc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageProductDeatils", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "AEPleAc1aaDDobJwtNBHAeTUIAgpWxr2iznF0coGsV0oIEBKCXtVsiSQujIeJPC2DA==");
        }
    }
}
