using System.Threading;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using AutoFixture.Xunit2;
using AutoMapper;
using DaBeerStorage.Functions.Data;
using DaBeerStorage.Functions.Interfaces;
using DaBeerStorage.Functions.Models;
using DaBeerStorage.Functions.Services;
using Moq;
using Xunit;

namespace DaBeerStorage.Tests.Data
{
    public class DaBeerStorageRepositoryTest
    {
        private DaBeerStorageRepository _rut;
        private Mock<IMapper> _map;
        private Mock<IDynamoDBContext> _context;
        public DaBeerStorageRepositoryTest()
        {
            _context = new Mock<IDynamoDBContext>();
            _map = new Mock<IMapper>();

            _rut = new DaBeerStorageRepository(_context.Object,_map.Object);
        }
        
        [Theory,AutoData]
        public void ShouldCallSaveAsync_WhenSaveBeer(string pk,Beer beer)
        {
            _rut.SaveBeer(pk, beer);
            
            _context.Verify(x => x.SaveAsync(It.IsAny<DaBeerStorageTable>(),It.IsAny<CancellationToken>()),Times.Once());
        }

        [Theory, AutoData]
        public void ShouldCallSaveAsync_WhenAddLocation(string pk,Location location)
        {
            _rut.AddLocation(pk, location);
            _context.Verify(x => x.SaveAsync(It.IsAny<DaBeerStorageTable>(),It.IsAny<CancellationToken>()),Times.Once());
        }
        
    }
}