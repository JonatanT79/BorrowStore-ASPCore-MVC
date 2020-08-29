using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductAPI.Migrations
{
    public partial class CreateProductsDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CopyCount = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductCopies",
                columns: table => new
                {
                    SerialNumber = table.Column<string>(nullable: false),
                    ProductsID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCopies", x => x.SerialNumber);
                    table.ForeignKey(
                        name: "FK_ProductCopies_Products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CopyCount", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 3, "Cool Book", "Book" },
                    { 2, 3, "Splendor", "BoardGame" },
                    { 3, 3, "Good for doing work", "MacBook" },
                    { 4, 3, "High Quality", "Guitar" }
                });

            migrationBuilder.InsertData(
                table: "ProductCopies",
                columns: new[] { "SerialNumber", "ProductsID" },
                values: new object[,]
                {
                    { "BOOK100", 1 },
                    { "BOOK200", 1 },
                    { "BOOK300", 1 },
                    { "BOARDGAME100", 2 },
                    { "BOARDGAME200", 2 },
                    { "BOARDGAME300", 2 },
                    { "MACBOOK100", 3 },
                    { "MACBOOK200", 3 },
                    { "MACBOOK300", 3 },
                    { "GUITAR100", 4 },
                    { "GUITAR200", 4 },
                    { "GUITAR300", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCopies_ProductsID",
                table: "ProductCopies",
                column: "ProductsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCopies");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
