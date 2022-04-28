using BurgerShop.Models;
using BurgerShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerShop.Controllers
{
    public class BurgerController : Controller
    {
        private readonly IBurgerRepository _burgerRepository;
        private readonly ICategoryRepository _categoryRepository;

        public BurgerController(IBurgerRepository burgerRepository, ICategoryRepository categoryRepository)
        {
            
            _burgerRepository = burgerRepository;
            _categoryRepository = categoryRepository;
        }
        public ViewResult List()
        {
            BurgersListViewModel burgersListViewModel = new BurgersListViewModel();
            burgersListViewModel.Burgers = _burgerRepository.AllBurgers;

            burgersListViewModel.CurrentCategory = "King Burger";
            return View(burgersListViewModel);
        }
       public IActionResult Details(int Id)
        {
            var burger = _burgerRepository.GetBurgerById(Id);
            if (burger == null)
                return NotFound();
            return View(burger);
        }
    }
}
