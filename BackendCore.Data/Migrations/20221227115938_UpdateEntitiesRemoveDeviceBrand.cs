using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntitiesRemoveDeviceBrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrandDevice",
                columns: table => new
                {
                    BrandsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DevicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandDevice", x => new { x.BrandsId, x.DevicesId });
                    table.ForeignKey(
                        name: "FK_BrandDevice_Brands_BrandsId",
                        column: x => x.BrandsId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrandDevice_Devices_DevicesId",
                        column: x => x.DevicesId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AI8Cop9S3ZFWnckqhrAj6QVLJEK+yQb6/wWWPKhtISMriXufHdXDL/prC8OOcEqAwA==");

            migrationBuilder.CreateIndex(
                name: "IX_BrandDevice_DevicesId",
                table: "BrandDevice",
                column: "DevicesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrandDevice");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AEyzbTVlNfDWtY6l8SokhviusJU36nh2gASHsKAaR/iFh7aV/OPHeekGyDGHz/v2cA==");
        }
    }
}
