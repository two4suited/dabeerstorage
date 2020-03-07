using AutoMapper;
using DaBeerStorage.Functions.Mappings;
using Xunit;

namespace DaBeerStorage.Tests.Mappings
{
    public class LocationMappingTest
    {
        [Fact]
        public void CreateToLocation_IsValid()
        {
            var config = new MapperConfiguration(cfg => { cfg.AddProfile<CreateToLocation>(); });
            config.AssertConfigurationIsValid();
        }
        

    }
}

