using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalDevelop.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "Detail", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 10, "ABCD", "Dell Notebook XPS 13", 55000.0 },
                    { 2, 5, "ABCD", "Lenovo X230", 32000.0 },
                    { 3, 3, "ABCD", "Microsoft Surface Pro 7", 60000.0 },
                    { 4, 10, "ABCD", "Apple Macbook Pro 2020", 45000.0 },
                    { 10, 1, "ABCD", "Apple Mac Pro", 100000.0 },
                    { 11, 20, "ABCD", "Apple Ipad 2018", 15000.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
