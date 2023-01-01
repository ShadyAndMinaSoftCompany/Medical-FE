using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class AddPaymentTypeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaymentStatus",
                table: "Transactions",
                newName: "TransactionStatus");

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentTypeId",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "AJG69oh+u6stsgQQjfIH++GpMTv6Acz7uALYljP1caIp/pmF0QBUwMUVxwkpxEzBDA==");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "TransactionStatus",
                table: "Transactions",
                newName: "PaymentStatus");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "AICyiJEmMrO2luO0q1/ButWi6J5OkBDyrmmJ+5CNapdbp/dRtbBTDqKBn1f0ys6Z6w==");
        }
    }
}
