using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WorldRecipies.Models;
using WorldRecipies.Services.Data;
using WorldRecipies.Web.Models;

namespace WorldRecipies.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWorldRecipiesRepository _worldRecipiesRepository;

        public HomeController(IWorldRecipiesRepository worldRecipiesRepository)
        {
            _worldRecipiesRepository = worldRecipiesRepository;
        }

        public IActionResult Index()
        {
            HomeViewModel MyModel = new HomeViewModel();
            MyModel.continents = _worldRecipiesRepository.GetContinents().ToList();
            MyModel.recipies = _worldRecipiesRepository.GetRecipies().ToList();
            MyModel.Countries = _worldRecipiesRepository.GetCountries().ToList();

            var random = new Random();

            MyModel.SelectedCountry = MyModel.recipies[random.Next(0, MyModel.recipies.Count() - 1)];
            MyModel.SelectedCountryTwo = MyModel.recipies[random.Next(0, MyModel.recipies.Count() - 1)];
            MyModel.SelectedCountryThree = MyModel.recipies[random.Next(0, MyModel.recipies.Count() - 1)];

            return View(MyModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
