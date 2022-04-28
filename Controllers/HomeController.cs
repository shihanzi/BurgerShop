using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerShop.Models;
using BurgerShop.ViewModels;

namespace BurgerShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBurgerRepository _burgerRepository;

        public HomeController(IBurgerRepository burgerRepository)
        {
            _burgerRepository = burgerRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                BurgerOfTheWeek = _burgerRepository.BurgersOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}

