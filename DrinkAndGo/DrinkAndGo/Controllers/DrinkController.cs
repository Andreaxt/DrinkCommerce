using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.ViewModels;

namespace DrinkAndGo.Data.Controllers
{
    public class DrinkController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        private readonly ICategoryRepository _categoryRepository;

        public DrinkController(IDrinkRepository drinkRepository, ICategoryRepository categoryRepository)
        {
            _drinkRepository = drinkRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult List()
        {
            ViewBag.name = "DotNet, who?";
            var drinks = _drinkRepository.Drinks;

            var vm = new DrinkListViewModel();
            vm.Drinks = drinks;
            vm.CurrentCategory = "Drink Category";
            return View(vm);
        }
    }
}