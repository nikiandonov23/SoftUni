using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectronicIdentityApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixedTypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovedId",
                table: "UsersAddresses",
                newName: "MovedIn");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MovedOut",
                table: "UsersAddresses",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovedIn",
                table: "UsersAddresses",
                newName: "MovedId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MovedOut",
                table: "UsersAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
