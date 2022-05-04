using Microsoft.EntityFrameworkCore;

namespace BurgerShop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet <ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Chicken Burgers" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Cheese Burgers" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Seasonal Burgers" });

            //seed Burgers

            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 1,
                Name = "Chicken Burger",
                Price = 350M,
                Description = "Our famous Chicken Burgers!",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/appleBurger.jpg",
                InStock = true,
                IsBurgerOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/appleBurgersmall.jpg",
            });

            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 2,
                Name = "Cheese Burger",
                Price = 850M,
                Description = "You'll love it!",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                InStock = true,
                IsBurgerOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                
            });

            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 3,
                Name = "King Burger",
                Price = 750M,
                Description = "Plain cheese Burger. Plain pleasure.",
               CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                InStock = true,
                IsBurgerOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                
            });

            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 4,
                Name = "Junior Burger",
                Price = 1500M,
                Description = "A summer classic!",  
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherryBurger.jpg",
                InStock = true,
                IsBurgerOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherryBurgersmall.jpg",
                
            });

            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 5,
                Name = "Christmas Burger",
                Price = 1390M,
                Description = "Happy holidays with this Burger!",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasappleBurger.jpg",
                InStock = true,
                IsBurgerOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasappleBurgersmall.jpg",
                
            });

            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 6,
                Name = "Double Delight Burger",
                Price = 1290M,
                Description = "A Christmas favorite",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberryBurger.jpg",
                InStock = true,
                IsBurgerOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberryBurgersmall.jpg",
                
            });

            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 7,
                Name = "Beef Burger",
                Price = 1590M,
                Description = "Tasty as Beef",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachBurger.jpg",
                InStock = false,
                IsBurgerOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachBurgersmall.jpg",
                
            });

            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 8,
                Name = "Prawn Burger",
                Price = 1295M,
                Description = "Our Prawn favorite",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinBurger.jpg",
                InStock = true,
                IsBurgerOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinBurgersmall.jpg",
                
            });


            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 9,
                Name = "SeaFood Burger",
                Price = 1195M,
                Description = "My God, Sea Food!",
                
                   CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbBurger.jpg",
                InStock = true,
                IsBurgerOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbBurgersmall.jpg",
                
            });

            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 10,
                Name = "Double Patty Burger",
                Price = 595M,
                Description = "Our delicious Patty Burger!",
                
                    CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryBurger.jpg",
                InStock = true,
                IsBurgerOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryBurgersmall.jpg",
                
            });

            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 11,
                Name = "Tuna Cheese Burger",
                Price = 1895M,
                Description = "You'll love it!",
                    CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                InStock = false,
                IsBurgerOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
                
            });
        }
    }
}