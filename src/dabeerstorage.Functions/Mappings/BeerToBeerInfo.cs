using AutoMapper;
using DaBeerStorage.Functions.ApiModels.Search;
using DaBeerStorage.Functions.Untappd.Models.BeerInfo;

namespace DaBeerStorage.Functions.Mappings
{
    public class BeerToBeerInfo : Profile
    {
        public BeerToBeerInfo()
        {
            CreateMap<Beer, ById>();
                /*
                .ForMember(x => x.Name, c => c.MapFrom(x => x.BeerName))
                .ForMember(x => x.AlchoholByVolume, c => c.MapFrom(x => x.BeerAbv))
                .ForMember(x => x.BreweryName, c => c.MapFrom(x => x.Brewery.BreweryName))
                .ForMember(x => x.Description, c => c.MapFrom(x => x.BeerDescription))
                .ForMember(x => x.Ibu, c => c.MapFrom(x => x.BeerIbu))
                .ForMember(x => x.LabelPath, c => c.MapFrom(x => x.BeerLabel))
                .ForMember(x => x.Style, c => c.MapFrom(x => x.BeerStyle))
                .ForMember(x => x.BreweryState, c => c.MapFrom(x => x.Brewery.Location.BreweryState))
                .ForMember(x => x.Rating, c => c.MapFrom(x => x.RatingScore.ToString()))
                .ForMember(x => x.UntappedId, c => c.MapFrom(x => x.Bid))
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
