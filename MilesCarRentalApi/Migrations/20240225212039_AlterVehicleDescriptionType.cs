using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilesCarRentalApi.Migrations
{
    /// <inheritdoc />
    public partial class AlterVehicleDescriptionType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Vehicles",
                type: "text",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Description",
                table: "Vehicles",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
