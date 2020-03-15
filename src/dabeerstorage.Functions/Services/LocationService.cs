using DaBeerStorage.Functions.ApiModels.Location;
using DaBeerStorage.Functions.Interfaces;
using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.Services
{
    public class LocationService : ILocationService
    {
        private readonly IDaBeerStorageRepository _repository;

        public LocationService(IDaBeerStorageRepository repository)
        {
            _repository = repository;
        }
        public Location Add(Add newLocation)
        {
            throw new System.NotImplementedException();
        }

        public ListLocation List()
        {
            throw new System.NotImplementedException();
        }
    }
}