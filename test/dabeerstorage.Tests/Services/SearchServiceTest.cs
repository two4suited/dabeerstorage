using AutoFixture.Xunit2;
using DaBeerStorage.Functions.ApiModels.Search;
using DaBeerStorage.Functions.Interfaces;
using DaBeerStorage.Functions.Services;
using Moq;
using Xunit;

namespace DaBeerStorage.Tests.Services
{
    public class SearchServiceTest
    {
        private SearchService _sut;
        private Mock<IBeerSearchRepository> _storage;
        public SearchServiceTest()
        {
            _storage = new Mock<IBeerSearchRepository>();

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
    }
}