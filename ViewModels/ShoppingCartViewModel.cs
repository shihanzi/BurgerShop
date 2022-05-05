using BurgerShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public decimal ShoppingCartTotal { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
