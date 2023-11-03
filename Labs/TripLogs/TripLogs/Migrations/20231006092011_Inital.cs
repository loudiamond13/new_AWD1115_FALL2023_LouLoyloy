using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TripLogs.Migrations
{
    /// <inheritdoc />
    public partial class Inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Accommodation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccommodationPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccommodationEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDo3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
