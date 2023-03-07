using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    Duration = table.Column<uint>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BicycleDataEntries", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BicycleDataEntries");
        }
    }
}
