using AutoMapper;
using DaBeerStorage.Functions.Mappings;
using Xunit;

    public class BeerMappingTest
    {

        [Fact]
        public void BeerToListNotDrank_IsValid()
        {
            var config = new MapperConfiguration(cfg => { cfg.AddProfile<BeerToListNotDrank>(); });
            config.AssertConfigurationIsValid();
        }

        [Fact]
        public void CreateToBeer_IsValid()
        {
            var config = new MapperConfiguration(cfg => {cfg.AddProfile<CreateToBeer>();});
            config.AssertConfigurationIsValid();
        }
        [Fact]
        public void SearchToCreate_IsValid()
        {
            var config = new MapperConfiguration(cfg => { cfg.AddProfile<SearchToCreate>(); });
            config.AssertConfigurationIsValid();
        }


    }

