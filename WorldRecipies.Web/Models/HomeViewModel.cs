using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorldRecipies.Models;
using WorldRecipies.Web.Controllers;

namespace WorldRecipies.Web.Models
{
    public class HomeViewModel
    {
        public List<Recipie> recipies { get; set; }
        public List<Continent> continents { get; set; }
        public Recipie SelectedCountry { get; set; }
        public Recipie SelectedCountryTwo { get; set; }

        public Recipie SelectedCountryThree { get; set; }

        public List<Country> Countries { get; set;  }
       
    }
}
