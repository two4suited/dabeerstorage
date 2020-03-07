using AutoMapper;
using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.Mappings
{
    public class CreateToBeer : Profile
    {
        public CreateToBeer()
        {
            CreateMap<Create, Beer>();

        }
    }
}
