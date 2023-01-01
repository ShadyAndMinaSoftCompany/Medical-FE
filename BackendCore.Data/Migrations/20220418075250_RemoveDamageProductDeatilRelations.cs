using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class RemoveDamageProductDeatilRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DamageProductDeatils_Products_ProducId",
                table: "DamageProductDeatils");

            migrationBuilder.DropIndex(
                name: "IX_DamageProductDeatils_ProducId",
                table: "DamageProductDeatils");

            migrationBuilder.RenameColumn(
                name: "ProducId",
                table: "DamageProductDeatils",
                newName: "ProductId");

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
                value: "AEPleAc1aaDDobJwtNBHAeTUIAgpWxr2iznF0coGsV0oIEBKCXtVsiSQujIeJPC2DA==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductsHistories");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "DamageProductDeatils",
                newName: "ProducId");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "AHBi2jV14nvbbOOdu1tGQcjvNQiu2FsXnO/lcZ0ixXU9tK3iKOxN2IjwhETpzEXbjQ==");

            migrationBuilder.CreateIndex(
                name: "IX_DamageProductDeatils_ProducId",
                table: "DamageProductDeatils",
                column: "ProducId");

            migrationBuilder.AddForeignKey(
                name: "FK_DamageProductDeatils_Products_ProducId",
                table: "DamageProductDeatils",
                column: "ProducId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
