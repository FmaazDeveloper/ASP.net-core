using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameZone.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Device",
                table: "GameDevices");

            migrationBuilder.DropColumn(
                name: "Game",
                table: "GameDevices");

            migrationBuilder.CreateIndex(
                name: "IX_GameDevices_DeviceId",
                table: "GameDevices",
                column: "DeviceId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameDevices_Devices_DeviceId",
                table: "GameDevices",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameDevices_Devices_DeviceId",
                table: "GameDevices");

            migrationBuilder.DropIndex(
                name: "IX_GameDevices_DeviceId",
                table: "GameDevices");

            migrationBuilder.AddColumn<int>(
                name: "Device",
                table: "GameDevices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Game",
                table: "GameDevices",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
