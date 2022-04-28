using Microsoft.EntityFrameworkCore.Migrations;

namespace BurgerShop.Migrations
{
    public partial class RemoveImagePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Burgers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Burgers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
