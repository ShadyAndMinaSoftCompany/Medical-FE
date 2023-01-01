using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    public partial class UpdatePropertiessNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "ACrtq8KOipH2m5WwqSLcWjTGiRt+TgCXimTVXYCLwH2xJBkEmPtSE+yzj1kOMbzVfg==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "Password",
                value: "ANfM4ncEtsSrAa7hZjSIgBVOW1oE9NNuYnPuUvlBH1U66m4EDcsXHwrrl3lzvGSDZA==");
        }
    }
}
