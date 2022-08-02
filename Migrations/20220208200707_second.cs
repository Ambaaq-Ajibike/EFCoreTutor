using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreTuto.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Book",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ISBN",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Book");
        }
    }
}
