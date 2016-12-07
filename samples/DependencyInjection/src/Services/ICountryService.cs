using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Models.Entities;

namespace src.Services
{
    public interface ICountryService 
    { 
        IEnumerable<Country> All(); 
    }
}