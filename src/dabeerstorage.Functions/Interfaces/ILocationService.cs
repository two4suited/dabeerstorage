using System.Collections.Generic;
using System.Threading.Tasks;
using DaBeerStorage.Functions.ApiModels.Location;
using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.Interfaces
{
    public interface ILocationService
    {
        Task<Location> Add(Add newLocation);
        Task<List<ListLocation>> List();
    }
}