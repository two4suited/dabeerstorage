using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<Location> Add(Add newLocation)
        {
            await _repository.AddLocation(newLocation.UserName, newLocation.ToCoreModel());
            return newLocation.ToCoreModel();
        }

        public Task<List<ListLocation>> List()
        {
            throw new System.NotImplementedException();
        }
    }
}