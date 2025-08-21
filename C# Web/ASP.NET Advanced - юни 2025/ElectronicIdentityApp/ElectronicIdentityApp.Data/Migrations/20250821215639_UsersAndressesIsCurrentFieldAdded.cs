using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectronicIdentityApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UsersAndressesIsCurrentFieldAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCurrent",
                table: "UsersAddresses",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCurrent",
                table: "UsersAddresses");
        }
    }
}
