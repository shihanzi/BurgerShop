using Microsoft.EntityFrameworkCore.Migrations;

namespace BurgerShop.Migrations
{
    public partial class Realdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Chicken Burgers", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Cheese Burgers", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Seasonal Burgers", null });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "BurgerId", "CategoryId", "Description", "ImagePath", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsBurgerOfTheWeek", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Our famous Chicken Burgers!", null, "https://gillcleerenpluralsight.blob.core.windows.net/files/appleBurgersmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/appleBurger.jpg", true, true, "Chicken Burger", 350m },
                    { 4, 1, "A summer classic!", null, "https://gillcleerenpluralsight.blob.core.windows.net/files/cherryBurgersmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherryBurger.jpg", true, false, "Junior Burger", 1500m },
                    { 7, 1, "Tasty as Beef", null, "https://gillcleerenpluralsight.blob.core.windows.net/files/peachBurgersmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachBurger.jpg", false, false, "Beef Burger", 1590m },
                    { 9, 1, "My God, Sea Food!", null, "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbBurgersmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbBurger.jpg", true, true, "SeaFood Burger", 1195m },
                    { 10, 1, "Our delicious Patty Burger!", null, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryBurgersmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryBurger.jpg", true, false, "Double Patty Burger", 595m },
                    { 2, 2, "You'll love it!", null, "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", true, false, "Cheese Burger", 850m },
                    { 3, 2, "Plain cheese Burger. Plain pleasure.", null, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", true, false, "King Burger", 750m },
                    { 11, 2, "You'll love it!", null, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", false, false, "Tuna Cheese Burger", 1895m },
                    { 5, 3, "Happy holidays with this Burger!", null, "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasappleBurgersmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasappleBurger.jpg", true, false, "Christmas Burger", 1390m },
                    { 6, 3, "A Christmas favorite", null, "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberryBurgersmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberryBurger.jpg", true, false, "Double Delight Burger", 1290m },
                    { 8, 3, "Our Prawn favorite", null, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinBurgersmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinBurger.jpg", true, true, "Prawn Burger", 1295m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
