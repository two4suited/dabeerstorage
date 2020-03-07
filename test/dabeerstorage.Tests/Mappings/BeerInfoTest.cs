using AutoMapper;
using DaBeerStorage.Functions.Mappings;
using Xunit;

namespace DaBeerStorage.Tests.Mappings
{
    public class BeerInfoTest
    {
        [Fact]
        public void BeerToBeerInfo_IsValid()
        {
            var config = new MapperConfiguration(cfg => { cfg.AddProfile<BeerToBeerInfo>(); });
            config.AssertConfigurationIsValid();
        }
    }
}

