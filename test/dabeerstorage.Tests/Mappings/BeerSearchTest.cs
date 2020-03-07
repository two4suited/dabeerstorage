using AutoMapper;
using DaBeerStorage.Functions.Mappings;
using Xunit;

namespace DaBeerStorage.Tests.Mappings
{
    public class BeerSearchMappingTest
    {
        [Fact]
        public void BeerToSearchByName_IsValid()
        {
            var config = new MapperConfiguration(cfg => { cfg.AddProfile<BeerToSearchByName>(); });
            config.AssertConfigurationIsValid();
        }
    }
}

