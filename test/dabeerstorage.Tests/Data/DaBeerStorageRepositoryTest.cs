using System.Threading;
using Amazon.DynamoDBv2.DataModel;
using AutoFixture.Xunit2;
using DaBeerStorage.Functions.Data;
using DaBeerStorage.Functions.Models;
using Moq;
using Xunit;

namespace DaBeerStorage.Tests.Data
{
    public class DaBeerStorageRepositoryTest
    {
        private DaBeerStorageRepository _rut;
        private Mock<IDynamoDBContext> _context;
        public DaBeerStorageRepositoryTest()
        {
            _context = new Mock<IDynamoDBContext>();

            _rut = new DaBeerStorageRepository(_context.Object);
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