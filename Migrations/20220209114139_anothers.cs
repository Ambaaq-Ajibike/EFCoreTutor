using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreTuto.Migrations
{
    public partial class anothers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Publisher");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Publisher",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
