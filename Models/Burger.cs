using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerShop.Models
{
    public class Burger
    {
        public int BurgerId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsBurgerOfTheWeek { get; set; }
        public bool InStock { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
