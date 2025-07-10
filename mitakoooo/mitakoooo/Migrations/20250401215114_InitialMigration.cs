using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mitakoooo.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specifics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specifics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regions_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HousingDeals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    SquareMeteres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor = table.Column<int>(type: "int", nullable: true),
                    GasHeating = table.Column<bool>(type: "bit", nullable: true),
                    CentralHeating = table.Column<bool>(type: "bit", nullable: true),
                    ConstructionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yard = table.Column<int>(type: "int", nullable: true),
                    UsageSpecifics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Views = table.Column<int>(type: "int", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HousingDeals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HousingDeals_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HousingDeals_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HousingDealSpecifics",
                columns: table => new
                {
                    HousingDealId = table.Column<int>(type: "int", nullable: false),
                    SpecificId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HousingDealSpecifics", x => new { x.HousingDealId, x.SpecificId });
                    table.ForeignKey(
                        name: "FK_HousingDealSpecifics_HousingDeals_HousingDealId",
                        column: x => x.HousingDealId,
                        principalTable: "HousingDeals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HousingDealSpecifics_Specifics_SpecificId",
                        column: x => x.SpecificId,
                        principalTable: "Specifics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HousingDeals_LocationId",
                table: "HousingDeals",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_HousingDeals_RegionId",
                table: "HousingDeals",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_HousingDealSpecifics_SpecificId",
                table: "HousingDealSpecifics",
                column: "SpecificId");

            migrationBuilder.CreateIndex(
                name: "IX_Regions_LocationId",
                table: "Regions",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Specifics_Name",
                table: "Specifics",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HousingDealSpecifics");

            migrationBuilder.DropTable(
                name: "HousingDeals");

            migrationBuilder.DropTable(
                name: "Specifics");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
