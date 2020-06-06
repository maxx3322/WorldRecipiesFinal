using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorldRecipies.Services.Data;
using WorldRecipies.Models;
using WorldRecipies.Web.Models;

namespace WorldRecipies.Web.Controllers
{
    [Route("/Countries")]
   
    public class CountriesController : Controller
    {
        private readonly IWorldRecipiesRepository _worldRecipiesRepository;

        public CountriesController(IWorldRecipiesRepository worldRecipiesRepository)
        {
            _worldRecipiesRepository = worldRecipiesRepository;
        }

        [HttpGet("Index/{countryId}")]
        public ActionResult Index(int countryId)
        {
            CountriesViewModel myView = new CountriesViewModel()
            { 
                Recipies = _worldRecipiesRepository.GetRecipies(countryId).ToList()


            };

           return View(myView);

        }
        [HttpGet("Recipies/{recipieId}")]
        public ActionResult Recipies(int recipieId)
        {
            CountriesViewModel myView = new CountriesViewModel()
            {
                Recipie = _worldRecipiesRepository.GetRecipie(recipieId)
            };
            return View(myView);
        }
       
    }
}