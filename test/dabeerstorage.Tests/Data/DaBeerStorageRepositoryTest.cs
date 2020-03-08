using Amazon.DynamoDBv2;
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
        private Mock<IAmazonDynamoDB> _db;
        private Mock<IMapper> _map;
        public DaBeerStorageRepositoryTest()
        {
            _db = new Mock<IAmazonDynamoDB>();
            _map = new Mock<IMapper>();

            _rut = new DaBeerStorageRepository(_db.Object,_map.Object);
        }
        /*
        [Theory,AutoData]
        public void ShouldCallSetBeerKeys_WhenSaveBeer(string pk,Beer beer,DaBeerStorageTable dynamoTable)
        {
            /*
            var table = new Mock<DaBeerStorageTable>();
            table.Setup(m => m(pk));
            _map.Setup(x => x.Map<DaBeerStorageTable>(beer)).Returns((DaBeerStorageTable t) => dynamoTable);
            
            _rut.SaveBeer(pk, beer);
            
            table.Verify(x => x.SetBeerKeys(pk),Times.Once());
            
        }
        */
    }
}