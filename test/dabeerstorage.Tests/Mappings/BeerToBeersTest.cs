using AutoMapper;
using DaBeerStorage.Functions.Mappings;
using Xunit;

namespace DaBeerStorage.Tests.Mappings
{
    public class BeerToDaBeerStorageTableMappingTest
    {
        [Fact]
        public void BeerToBeers_IsValid()
        {
            var config = new MapperConfiguration(cfg => { cfg.AddProfile<BeerToDaBeerStorageTable>(); });
            config.AssertConfigurationIsValid();
        }
    }
}

