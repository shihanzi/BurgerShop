using BurgerShop.Models;
using BurgerShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BurgerShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IBurgerRepository _burgerRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IBurgerRepository burgerRepository,ShoppingCart shoppingCart)
        {
            _burgerRepository = burgerRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int burgerId)
        {
            var selectedPie = _burgerRepository.AllBurgers.FirstOrDefault(b => b.BurgerId == burgerId);

            if (selectedPie != null)
            {
                _shoppingCart.AddToCart(selectedPie, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int burgerId)
        {
            var selectedPie = _burgerRepository.AllBurgers.FirstOrDefault(b => b.BurgerId == burgerId);

            if (selectedPie != null)
            {
                _shoppingCart.RemoveFromCart(selectedPie);
            }
            return RedirectToAction("Index");
        }
    }
}
