using AutoFixture.Xunit2;
using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Interfaces;
using DaBeerStorage.Functions.Models;
using DaBeerStorage.Functions.Services;
using Moq;
using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.Services
{
    public class BeerServiceTest
    {
        private BeerService _sut;
        private Mock<IDaBeerStorageRepository> _storage;
        public BeerServiceTest()
        {
            _storage = new Mock<IDaBeerStorageRepository>();

            _sut = new BeerService(_storage.Object);
        }
        [Theory,AutoData]
        public void Create_ShouldCallAddToMatchQuantity(int quantity,Create create)
        {
            create.Quantity = quantity;
     
            _sut.Create(create);

            _storage.Verify(mock => mock.SaveBeer(It.IsAny<string>(),It.IsAny<Beer>()), Times.Exactly(quantity));
        }

        [Theory,AutoData]
        public void Drink_ShouldCallGetBeer_and_UpdateBeer(Drink drink,Beer beer)
        {
            _storage.Setup(m => m.GetBeer(It.IsAny<string>(), It.IsAny<string>())).ReturnsAsync(beer);
            
            _sut.Drink(drink);
            
            _storage.Verify(m => m.GetBeer(It.IsAny<string>(),It.IsAny<string>()),Times.Once);
            _storage.Verify(m => m.SaveBeer(It.IsAny<string>(),It.IsAny<Beer>()),Times.Once);
        }

        [Theory, AutoData]
        public void ListNotDrank_ShouldCallListNotDrank(ListNotDrank listNotDrank)
        {
            _sut.ListNotDrank(listNotDrank);
            
            _storage.Verify(x => x.ListNotDrank(It.IsAny<string>()),Times.Once);
        }

        [Theory,AutoData]
        public void Move_Should_Call_GetAndUpdate(Move move,Beer beer)
        {
            _storage.Setup(m => m.GetBeer(It.IsAny<string>(), It.IsAny<string>())).ReturnsAsync(beer);            
            
            _sut.Move(move);
            _storage.Verify(m => m.GetBeer(It.IsAny<string>(),It.IsAny<string>()),Times.Once);
            _storage.Verify(m => m.SaveBeer(It.IsAny<string>(),It.IsAny<Beer>()),Times.Once);
        }
        
        [Theory,AutoData]
        public void Move_ShouldSetNewLocation(Move move,Beer beer)
        {
            _storage.Setup(m => m.GetBeer(It.IsAny<string>(), It.IsAny<string>())).ReturnsAsync(beer);
            
            _sut.Move(move);
            
            beer.Location.ShouldBe(move.NewLocation);
        }
    }
}