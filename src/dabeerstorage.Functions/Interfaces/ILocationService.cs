using DaBeerStorage.Functions.ApiModels.Location;
using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.Interfaces
{
    public interface ILocationService
    {
        Location Add(Add newLocation);
        ListLocation List();
    }
}