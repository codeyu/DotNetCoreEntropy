using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Models.Entities;

namespace src.Services
{
    public class CountryService : ICountryService 
    { 
        public IEnumerable<Country> All() 
        { 
            return new List<Country> 
            { 
                new Country {Code = "ZH", Name = "China" },
                new Country {Code = "DE", Name = "Germany" }, 
                new Country {Code = "FR", Name = "France" }, 
                new Country {Code = "CH", Name = "Switzerland" }, 
                new Country {Code = "IT", Name = "Italy" }, 
                new Country {Code = "DK", Name = "Danmark" } , 
                new Country {Code = "US", Name = "United States" }
            }; 
        } 
    } 
}