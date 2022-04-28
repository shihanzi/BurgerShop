using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerShop.Models
{
   public interface IBurgerRepository
    {
        IEnumerable<Burger> AllBurgers { get; }
        IEnumerable<Burger> BurgersOfTheWeek { get; }
        Burger GetBurgerById(int burgerId);
    }
}
