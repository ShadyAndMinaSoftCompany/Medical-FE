using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDepartmentDevicesEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentDevices");

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "Devices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AEyzbTVlNfDWtY6l8SokhviusJU36nh2gASHsKAaR/iFh7aV/OPHeekGyDGHz/v2cA==");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_DepartmentId",
                table: "Devices",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Departments_DepartmentId",
                table: "Devices",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Departments_DepartmentId",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_DepartmentId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Devices");

            migrationBuilder.CreateTable(
                name: "DepartmentDevices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentDevices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentDevices_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DepartmentDevices_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                column: "PasswordHash",
                value: "AKJy82/niO2UlFFbutj/7hhPneOMwhsQyfHyKDv5Eslbuudlyn8notvAkGd3neG5yg==");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentDevices_DepartmentId",
                table: "DepartmentDevices",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentDevices_DeviceId",
                table: "DepartmentDevices",
                column: "DeviceId");
        }
    }
}
