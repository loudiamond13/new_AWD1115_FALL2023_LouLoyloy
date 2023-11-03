using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FAQs.Migrations
{
    /// <inheritdoc />
    public partial class InitialFaqMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TopicName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicID);
                });

            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    FaqID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaqQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaqAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopicID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.FaqID);
                    table.ForeignKey(
                        name: "FK_Faqs_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Faqs_Topics_TopicID",
                        column: x => x.TopicID,
                        principalTable: "Topics",
                        principalColumn: "TopicID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { "gen", "General" },
                    { "hist", "History" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicID", "TopicName" },
                values: new object[,]
                {
                    { "boot", "Bootstrap" },
                    { "cs", "C#" },
                    { "js", "JavaScript" }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "FaqID", "CategoryID", "FaqAnswer", "FaqQuestion", "TopicID" },
                values: new object[,]
                {
                    { 1, "gen", "A general purpose object oriented language that uses a concise, Java-like syntax.", "What is C#?", "cs" },
                    { 2, "hist", "In 2002.", "When was C# first released?", "cs" },
                    { 3, "gen", "A general purpose scripting language that executes in a web browser.", "What is JavaScript?", "js" },
                    { 4, "hist", "In 1995.", "When was JavaScript first released?", "js" },
                    { 5, "gen", "A CSS framework for creating responsive web apps for multiple screen sizes.", "What is Bootstrap?", "boot" },
                    { 6, "hist", "In 2011.", "When was Bootstrap first released?", "boot" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faqs_CategoryID",
                table: "Faqs",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Faqs_TopicID",
                table: "Faqs",
                column: "TopicID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
