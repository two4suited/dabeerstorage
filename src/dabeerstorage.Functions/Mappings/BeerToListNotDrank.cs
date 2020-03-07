using AutoMapper;
using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.Mappings
{
    public class BeerToListNotDrank : Profile
    {
        public BeerToListNotDrank()
        {
            CreateMap<Beer, ListNotDrank>();

        }

    }
}