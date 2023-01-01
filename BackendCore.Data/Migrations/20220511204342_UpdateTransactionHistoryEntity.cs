using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class UpdateTransactionHistoryEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_PaymentTypes_PaymentTypeId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_PaymentTypeId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "PaymentTypeId",
                table: "Transactions");

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentTypeId",
                table: "TransactionHistories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AEBb8VAcGLxOgaPM8ZG1WKw7RFM0ieWJmN+J7DOa4cf3Wvu01ep4cZtu7Mo7fovm7Q==");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionHistories_PaymentTypeId",
                table: "TransactionHistories",
                column: "PaymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionHistories_PaymentTypes_PaymentTypeId",
                table: "TransactionHistories",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionHistories_PaymentTypes_PaymentTypeId",
                table: "TransactionHistories");

            migrationBuilder.DropIndex(
                name: "IX_TransactionHistories_PaymentTypeId",
                table: "TransactionHistories");

            migrationBuilder.DropColumn(
                name: "PaymentTypeId",
                table: "TransactionHistories");

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentTypeId",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AMaJaE8T7EzSt22xQYa1dlp2V5V6AGFbzmsmRvix2BnYqyZ/ATOvOUJLgUo8oH4N0Q==");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PaymentTypeId",
                table: "Transactions",
                column: "PaymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_PaymentTypes_PaymentTypeId",
                table: "Transactions",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "Id");
        }
    }
}
