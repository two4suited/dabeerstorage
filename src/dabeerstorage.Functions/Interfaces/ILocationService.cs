using System.Collections.Generic;
using System.Threading.Tasks;
using DaBeerStorage.Functions.ApiModels.Location;
using DaBeerStorage.Functions.Models;
using DaBeerStorage.Functions.ViewModels;

namespace DaBeerStorage.Functions.Interfaces
{
    public interface ILocationService
    {
        Task<Location> Add(Add newLocation);
        Task<List<LocationViewModel>> List(ListLocation listLocation);
    }
}