using AutoMapper;
using DaBeerStorage.Functions.Data;
using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.Mappings
{
    public class LocationToDaBeerStorageTable : Profile
    {
        public LocationToDaBeerStorageTable()
        {
            CreateMap<Location, DaBeerStorageTable>()
                .ForMember(dest => dest.PK, opt => opt.Ignore())
                .ForMember(dest => dest.SK, opt => opt.Ignore())
                .ForMember(dest => dest.BreweryKey, opt => opt.Ignore())
                .ForMember(dest => dest.BeerId, opt => opt.Ignore())
                .ForMember(dest => dest.BeerName, opt => opt.Ignore())
                .ForMember(dest => dest.UntappedId, opt => opt.Ignore())
                .ForMember(dest => dest.AlchoholByVolume, opt => opt.Ignore())
                .ForMember(dest => dest.BeerDescription, opt => opt.Ignore())
                .ForMember(dest => dest.LabelPath, opt => opt.Ignore())
                .ForMember(dest => dest.Style, opt => opt.Ignore())
                .ForMember(dest => dest.Ibu, opt => opt.Ignore())
                .ForMember(dest => dest.BrewerDbId, opt => opt.Ignore())
                .ForMember(dest => dest.Drank, opt => opt.Ignore())
                .ForMember(dest => dest.Rating, opt => opt.Ignore())
                .ForMember(dest => dest.DrankWhen, opt => opt.Ignore())
                .ForMember(dest => dest.BreweryName, opt => opt.Ignore())
                .ForMember(dest => dest.BreweryState, opt => opt.Ignore())
                .ForMember(dest => dest.DateAdded, opt => opt.Ignore())
                .ForMember(x => x.LocationName, c => c.MapFrom(x => x.Name)).ReverseMap();
        }
    }
}
