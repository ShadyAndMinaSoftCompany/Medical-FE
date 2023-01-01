using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModelDetails_Brands_BrandId",
                table: "ModelDetails");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "ModelDetails",
                newName: "DeviceBrandId");

            migrationBuilder.RenameIndex(
                name: "IX_ModelDetails_BrandId",
                table: "ModelDetails",
                newName: "IX_ModelDetails_DeviceBrandId");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AEg1ySaBemVUg9JuVXn2mmJag25WoXZYFe41TgFq5y3BM9wseDV+iBe7AdbClCveuQ==");

            migrationBuilder.AddForeignKey(
                name: "FK_ModelDetails_DeviceBrands_DeviceBrandId",
                table: "ModelDetails",
                column: "DeviceBrandId",
                principalTable: "DeviceBrands",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModelDetails_DeviceBrands_DeviceBrandId",
                table: "ModelDetails");

            migrationBuilder.RenameColumn(
                name: "DeviceBrandId",
                table: "ModelDetails",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_ModelDetails_DeviceBrandId",
                table: "ModelDetails",
                newName: "IX_ModelDetails_BrandId");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AAOMt5m9iyJTjqupyY0y6aKJDWF+t2Y2jTg+e1hXdmTohRGKN3TEVFr2uN5zJvB5JQ==");

            migrationBuilder.AddForeignKey(
                name: "FK_ModelDetails_Brands_BrandId",
                table: "ModelDetails",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");
        }
    }
}
