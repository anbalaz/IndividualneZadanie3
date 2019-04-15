using Data.Models;
using System.Collections.Generic;

namespace Data.Repositories
{
    public interface ICountryRepository
    {
        List<Country> SelectTowms();
    }
}