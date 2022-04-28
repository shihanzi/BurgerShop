using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerShop.Models;

namespace BurgerShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Burger> BurgerOfTheWeek { get; set; }
    }
}
