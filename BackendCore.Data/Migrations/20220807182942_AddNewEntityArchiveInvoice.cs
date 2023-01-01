using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class AddNewEntityArchiveInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AKQ9GSW1aPgaTTz2nmrt4bEwT4wNQlqx5NQcMHhry0/qmND9GZ5jrbOwMDSD0OwvcQ==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AA//ER9/hLlxCA3Mzb5xhRT6nAj5e4N+lyAJVochYDJ28yOH0QcfW+07dvsLmEo0eA==");
        }
    }
}
