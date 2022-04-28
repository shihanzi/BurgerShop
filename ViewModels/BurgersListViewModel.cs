using BurgerShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerShop.ViewModels
{
    public class BurgersListViewModel
    {
        public IEnumerable<Burger> Burgers { get; set; }
        public string CurrentCategory { get; set; }
    }
}
