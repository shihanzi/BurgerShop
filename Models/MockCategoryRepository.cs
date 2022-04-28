using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Beef Burger", Description="All Beef Items"},
                new Category{CategoryId=2, CategoryName="King Burger", Description="The King of the menu"},
                new Category{CategoryId=3, CategoryName="Chicken Burger", Description="For Chicken Lovers"}
            };
    }
}
