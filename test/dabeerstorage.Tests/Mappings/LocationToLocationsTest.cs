using AutoMapper;
using DaBeerStorage.Functions.Mappings;
using Xunit;

namespace DaBeerStorage.Tests.Mappings
{
    public class LocationToDaBeerStorageTableMappingTest
    {
        [Fact]
        public void BeerToBeers_IsValid()
        {
            var config = new MapperConfiguration(cfg => { cfg.AddProfile<LocationToDaBeerStorageTable>(); });
            config.AssertConfigurationIsValid();
        }
    }
}

