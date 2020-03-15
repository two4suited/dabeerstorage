using AutoFixture.Xunit2;
using DaBeerStorage.Functions.ApiModels.Location;
using DaBeerStorage.Functions.Interfaces;
using DaBeerStorage.Functions.Models;
using DaBeerStorage.Functions.Services;
using Moq;
using Xunit;

namespace DaBeerStorage.Tests.Services
{
    public class LocationServiceTest
    {
        private LocationService _sut;
        private Mock<IDaBeerStorageRepository> _storage;
        public LocationServiceTest()
        {
            _storage = new Mock<IDaBeerStorageRepository>();

            _sut = new LocationService(_storage.Object);
        }
        
        [Theory,AutoData]
        public void Add_Should_Call_AddLocation(Add location)
        {
            _sut.Add(location);
            _storage.Verify(x => x.AddLocation(It.IsAny<string>(),It.IsAny<Location>()),Times.Once);
        }
    }
}