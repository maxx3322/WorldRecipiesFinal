using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldRecipies.Models;

namespace WorldRecipies.Web.Models
{
    public class CountriesViewModel { 

       public string CountryName { get; set;}
       public string RecipieName { get; set; }

       public int RecipieId { get; set; }
       public Country Country { get; set; }
       public List<Recipie> Recipies { get; set; }
       public Recipie Recipie { get; set; }



        public int CountryId { get; set; }






    }
}
