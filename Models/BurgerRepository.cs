using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BurgerShop.Models
{
    public class BurgerRepository : IBurgerRepository
    {
        private readonly AppDbContext _appDbContext;
        public BurgerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Burger> AllBurgers
        {
            get
            {
                return _appDbContext.Burgers.Include(c => c.Category);
            }
    }

        public IEnumerable<Burger> BurgersOfTheWeek
        {
            get
            {
                return _appDbContext.Burgers.Include(c => c.Category).Where(p=> p.IsBurgerOfTheWeek);
            }
        }

    public Burger GetBurgerById(int burgerId)
        {
            return _appDbContext.Burgers.FirstOrDefault(p => p.BurgerId== burgerId);
        }
    }
}
