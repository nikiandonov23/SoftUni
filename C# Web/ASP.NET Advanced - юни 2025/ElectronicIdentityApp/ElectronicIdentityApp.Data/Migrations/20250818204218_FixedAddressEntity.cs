﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectronicIdentityApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixedAddressEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Addresses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
