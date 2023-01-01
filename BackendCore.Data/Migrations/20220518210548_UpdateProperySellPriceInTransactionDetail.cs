using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class UpdateProperySellPriceInTransactionDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UnitPrize",
                table: "TransactionDetails",
                newName: "SellPrice");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AO7ZotZC4XwMyXFd5sn9iULGmgwQt2562bWogwmRKG7SN9zlEpzjWB1+PULAnhb+Ng==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SellPrice",
                table: "TransactionDetails",
                newName: "UnitPrize");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AMfnE5fjWLRSc9N8R7JhXN3a2UCX5I+mj1Faq0bGCg0ph/kGlzqPuX3m9qgez6JSMg==");
        }
    }
}
