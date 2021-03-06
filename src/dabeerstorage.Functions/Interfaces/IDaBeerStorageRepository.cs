﻿using System.Collections.Generic;
using System.Threading.Tasks;
using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.Interfaces
{
    public interface IDaBeerStorageRepository
    {
        Task<Location> AddLocation(string pk,Location location);
        Task<List<Location>> ListLocation(string pk);
        Task<Beer> SaveBeer(string pk,Beer beer);
        Task<Beer> GetBeer(string pk,string id);
        Task<List<Beer>> ListNotDrank(string pk);
        Task<List<Beer>> GetBrewery(string pk,string breweryName);
    }
}
