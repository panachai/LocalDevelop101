using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalDevelop.Migrations
{
    public partial class updateproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Apple X Pro 2020");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "Detail", "Name", "Price" },
                values: new object[] { 13, 20, "ABCD", "Apple Ipad 2018", 15000.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "Detail", "Name", "Price" },
                values: new object[] { 12, 20, "ABCD", "Apple Ipad 2018", 15000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Apple Macbook Pro 2020");
        }
    }
}
