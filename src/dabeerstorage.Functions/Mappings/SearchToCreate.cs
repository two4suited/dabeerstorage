using AutoMapper;
using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.Mappings
{
    public class SearchToCreate : Profile
    {
        public SearchToCreate()
        {
            CreateMap<Beer, Create>()
                .ForMember(dest => dest.BrewerDbId, opt => opt.Ignore())
             .ForMember(dest => dest.Quantity, opt => opt.Ignore())
             .ForMember(dest => dest.UserName, opt => opt.Ignore());

        }


    }
}
