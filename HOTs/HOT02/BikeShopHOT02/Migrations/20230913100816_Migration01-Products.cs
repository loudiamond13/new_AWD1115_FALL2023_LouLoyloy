using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BikeShopHOT02.Migrations
{
    /// <inheritdoc />
    public partial class Migration01Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescShort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescLong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    ProductQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "ProductDescLong", "ProductDescShort", "ProductImage", "ProductName", "ProductPrice", "ProductQty" },
                values: new object[,]
                {
                    { 1, 1, "", "", "", "AeroFlo ATB Wheels", 189m, 40 },
                    { 2, 6, "", "", "", "Clear Shade 85-T Glasses", 45m, 14 },
                    { 3, 1, "", "", "", "Cosmic Elite Road Warrior Wheels", 165m, 22 },
                    { 4, 4, "", "", "", "Cycle-Doc Pro Repair Stands", 166m, 12 },
                    { 5, 6, "", "", "", "Dog Ear Aero-Flow Floor Pumps", 55m, 25 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
