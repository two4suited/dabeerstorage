using System.Collections.Generic;
using AutoFixture.Xunit2;
using DaBeerStorage.Functions.ApiModels.Search;
using DaBeerStorage.Functions.Interfaces;
using DaBeerStorage.Functions.Services;
using DaBeerStorage.Functions.Untappd.Models.BeerSearch;
using DaBeerStorage.Functions.ViewModels;
using Moq;
using Shouldly;
using Xunit;
using Beer = DaBeerStorage.Functions.Untappd.Models.BeerInfo.Beer;

namespace DaBeerStorage.Tests.Services
{
    public class SearchServiceTest
    {
        private SearchService _sut;
        private Mock<IBeerSearchRepository> _storage;
        private Mock<SearchViewModel> _viewModel;
        public SearchServiceTest()
        {
            _storage = new Mock<IBeerSearchRepository>();
            _viewModel = new Mock<SearchViewModel>();

            _sut = new SearchService(_storage.Object);
        }

        [Theory, AutoData]
        public void ById_Should_Call_Method(ById byid)
        {
            _sut.SearchById(byid);
            
            _storage.Verify(x => x.SearchById(It.IsAny<string>()),Times.Once);
        }
        [Theory, AutoData]
        public void ByName_Should_Call_Method(ByName byName)
        {
            _sut.SearchByName(byName);
            
            _storage.Verify(x => x.SearchByName(It.IsAny<int>(),It.IsAny<string>()),Times.Once);
        }

        [Theory, AutoData]
        public void ByName_Should_Map(ByName byName,List<Item> items)
        {
            _storage.Setup(m => m.SearchByName(It.IsAny<int>(), It.IsAny<string>())).ReturnsAsync(items);

            
            var results = _sut.SearchByName(byName).Result;
            
            results.Count.ShouldBe(items.Count);
        }
        
        [Theory, AutoData]
        public void ById_Should_Map(ById byId,Beer beer)
        {
            _storage.Setup(m => m.SearchById(It.IsAny<string>())).ReturnsAsync(beer);

            
            var results = _sut.SearchById(byId).Result;
            
            results.BeerName.ShouldBe(beer.BeerName);
        }
    }
}