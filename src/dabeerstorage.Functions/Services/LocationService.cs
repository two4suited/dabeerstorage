using System.Collections.Generic;
using System.Threading.Tasks;
using DaBeerStorage.Functions.ApiModels.Location;
using DaBeerStorage.Functions.Interfaces;
using DaBeerStorage.Functions.Models;
using DaBeerStorage.Functions.ViewModels;

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

        public async Task<List<LocationViewModel>> List(ListLocation listLocation)
        {
           var locations =  await _repository.ListLocation(listLocation.UserName);
           return LocationViewModel.FromCoreModels(locations);
        }
    }
}