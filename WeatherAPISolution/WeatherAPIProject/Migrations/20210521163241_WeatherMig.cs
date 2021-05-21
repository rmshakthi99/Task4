using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherAPIProject.Migrations
{
    public partial class WeatherMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "w",
                columns: table => new
                {
                    City = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LowTemp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighTemp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForeCast = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_w", x => x.City);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "w");
        }
    }
}
