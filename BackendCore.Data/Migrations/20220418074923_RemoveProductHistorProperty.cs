using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class RemoveProductHistorProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "ANSCiGxgNi7LSLIUVz3NmUtntOZYSOtoDeMt5Zq6e5BX5ydBH1N+JYdCqOKd/b9gXg==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "AEpCMP+P1SHESug0qCvrroeWceM7Tw1vGUdgt/pClBhv5wrIPfBnyob0FGGm0MPJuA==");
        }
    }
}
