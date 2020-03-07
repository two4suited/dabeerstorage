using AutoMapper;
using DaBeerStorage.Functions.Data;
using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.Mappings
{
    public class BeerToDaBeerStorageTable : Profile
    {
        public BeerToDaBeerStorageTable()
        {
            CreateMap<Beer, DaBeerStorageTable>()
                .ForMember(dest => dest.PK, opt => opt.Ignore())
                .ForMember(dest => dest.SK, opt => opt.Ignore())
                .ForMember(dest => dest.BreweryKey, opt => opt.Ignore())
                .ForMember(x => x.BeerName, c => c.MapFrom(x => x.Name))
                .ForMember(x => x.LocationName, c => c.MapFrom(x => x.Location))
                .ForMember(x => x.BeerDescription, c => c.MapFrom(x => x.Description)).ReverseMap();
        }
    }

    //public class DaBeerStorageTableToBeer : Profile
    //{
    //    public DaBeerStorageTableToBeer()
    //    {
    //        CreateMap<DaBeerStorageTable, Beer>()

    //    }
    //}
}
