using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerShop.Models
{
    public class MockBurgerRepository : IBurgerRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Burger> AllBurgers =>
            new List<Burger>
            {
                new Burger {BurgerId = 1, Name="Chicken Burger", Price=700.00M, Description="Chicken Burger", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://1sbnfv2h0tci3kwvug47tobt-wpengine.netdna-ssl.com/wp-content/uploads/2020/08/Grilled-Chicken_Classic-Sandwich_web-286x215.png", InStock=true, IsBurgerOfTheWeek=false, ImageThumbnailUrl="https://1sbnfv2h0tci3kwvug47tobt-wpengine.netdna-ssl.com/wp-content/uploads/2020/08/Grilled-Chicken_Classic-Sandwich_web-286x215.png"},
                new Burger {BurgerId = 2, Name="Cheese Burger", Price=850.00M, Description="Lorem Ipsum", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://1sbnfv2h0tci3kwvug47tobt-wpengine.netdna-ssl.com/wp-content/uploads/2022/02/Beef_Colorado_Single_Web-286x215.png", InStock=true, IsBurgerOfTheWeek=false, ImageThumbnailUrl="https://1sbnfv2h0tci3kwvug47tobt-wpengine.netdna-ssl.com/wp-content/uploads/2022/02/Beef_Colorado_Single_Web-286x215.png"},
                new Burger {BurgerId = 3, Name="Beef Burger", Price=950.00M, Description="Lorem Ipsum", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="~/images/thumb/valentine.png", InStock=true, IsBurgerOfTheWeek=true, ImageThumbnailUrl="./images/thumb/valentine.png"},
                new Burger {BurgerId = 4, Name="Pumpkin Burger", Price=650.00M, Description="Lorem Ipsum",  Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl=@"D:\BurgerShop\BurgerShop\wwwroot\Images\Thumb\valentine.png", InStock=true, IsBurgerOfTheWeek=true, ImageThumbnailUrl=@"D:\BurgerShop\BurgerShop\wwwroot\Images\Thumb\valentine.png"}
            };

        public IEnumerable<Burger> BurgersOfTheWeek { get; }

        public Burger GetBurgerById(int burgerId)
        {
            return AllBurgers.FirstOrDefault(p => p.BurgerId == burgerId);
        }
    }
}