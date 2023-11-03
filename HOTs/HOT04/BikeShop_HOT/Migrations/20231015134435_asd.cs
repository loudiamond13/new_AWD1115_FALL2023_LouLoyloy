using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikeShop_HOT.Migrations
{
    /// <inheritdoc />
    public partial class asd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 7,
                column: "CategoryName",
                value: "Ω Uncategorized Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 7,
                column: "CategoryName",
                value: "Uncategorized Products");
        }
    }
}
