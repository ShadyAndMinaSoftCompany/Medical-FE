using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class AddStatusAndReasonColumnsInLoginHistoryEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "LoginHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Statue",
                table: "LoginHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "ABn6pjhLxLzPKpNnHWzZOPIIDnI0X+6HNiA2L+Iqcr/shwCMCKzO4M/FlzVPXwcGyg==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reason",
                table: "LoginHistories");

            migrationBuilder.DropColumn(
                name: "Statue",
                table: "LoginHistories");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "AJXS+scZJDX057XzuXoRceZOCLbKGhmelFdAUns3uXG9yb/hd/DKTfjazrizU0pKPw==");
        }
    }
}
