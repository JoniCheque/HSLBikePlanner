using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class SetUpMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BicycleDataEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Departure = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Return = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DepartureStationId = table.Column<string>(type: "TEXT", nullable: false),
                    DepartureStationName = table.Column<string>(type: "TEXT", nullable: false),
                    ReturnStationId = table.Column<string>(type: "TEXT", nullable: false),
                    ReturnStationName = table.Column<string>(type: "TEXT", nullable: false),
                    Distance = table.Column<int>(type: "INTEGER", nullable: false),
                    Duration = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BicycleDataEntries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    StationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    StationStrId = table.Column<string>(type: "TEXT", nullable: false),
                    Lat = table.Column<decimal>(type: "TEXT", nullable: false),
                    Lon = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.StationId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BicycleDataEntries");

            migrationBuilder.DropTable(
                name: "Stations");
        }
    }
}
