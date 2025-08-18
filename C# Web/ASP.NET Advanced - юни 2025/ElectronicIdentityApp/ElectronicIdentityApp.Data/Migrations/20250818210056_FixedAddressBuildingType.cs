using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectronicIdentityApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixedAddressBuildingType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BuildingType",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuildingType",
                table: "Addresses");
        }
    }
}
