using AutoMapper;
using DaBeerStorage.Functions.ApiModels.Location;
using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.Mappings
{
    public class CreateToLocation : Profile
    {
        public CreateToLocation()
        {
            CreateMap<Add, Location>();
        }
       
    }
}
