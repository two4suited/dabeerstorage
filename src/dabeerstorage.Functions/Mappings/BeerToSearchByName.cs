using AutoMapper;
using DaBeerStorage.Functions.ApiModels.Search;
using DaBeerStorage.Functions.Untappd.Models.BeerSearch;

namespace DaBeerStorage.Functions.Mappings
{
    public class BeerToSearchByName : Profile
    {
        public BeerToSearchByName()
        {
            CreateMap<Item, ByName>();
                /*
                .ForMember(x => x.Name, c => c.MapFrom(x => x.Beer.BeerName))
                .ForMember(x => x.AlchoholByVolume, c => c.MapFrom(x => x.Beer.BeerAbv))
                .ForMember(x => x.BreweryName, c => c.MapFrom(x => x.Brewery.BreweryName))
                .ForMember(x => x.Description, c => c.MapFrom(x => x.Beer.BeerDescription))
                .ForMember(x => x.Ibu, c => c.MapFrom(x => x.Beer.BeerIbu))
                .ForMember(x => x.LabelPath, c => c.MapFrom(x => x.Beer.BeerLabel))
                .ForMember(x => x.Style, c => c.MapFrom(x => x.Beer.BeerStyle))
                .ForMember(x => x.BreweryState, c => c.MapFrom(x => x.Brewery.Location.BreweryState))
                .ForMember(x => x.Rating, c => c.MapFrom(x => x.Beer.AuthRating))
                .ForMember(x => x.UntappedId, c => c.MapFrom(x => x.Beer.Bid))
                .ForMember(dest => dest.BeerId, opt => opt.Ignore())
                .ForMember(dest => dest.BrewerDbId, opt => opt.Ignore())
                .ForMember(dest => dest.Drank, opt => opt.Ignore())
                .ForMember(dest => dest.DrankWhen, opt => opt.Ignore())
                .ForMember(dest => dest.DateAdded, opt => opt.Ignore())
                .ForMember(dest => dest.GaveWay, opt => opt.Ignore())
                .ForMember(dest => dest.Location, opt => opt.Ignore());*/

        }
    }
}
