using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using AutoMapper;
using DaBeerStorage.Functions.Interfaces;
using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.Data
{
    public class DaBeerStorageRepository : IDaBeerStorageRepository
    {
        private readonly IMapper _dynamoMapper;
        private readonly IDynamoDBContext _context;

        public DaBeerStorageRepository(IDynamoDBContext context, IMapper dynamoMapper)
        {
            _dynamoMapper = dynamoMapper;
            _context = context;
        }

        public async Task<Location> AddLocation(string pk,Location location)
        {
            var table = DaBeerStorageTable.MapFromLocation(location,pk);
            
            await _context.SaveAsync(table);
            return location;
        }

        public async Task<List<Location>> ListLocation(string pk)
        {
            string[] filter = { "Location" };
            var items = await _context.QueryAsync<DaBeerStorageTable>(pk,QueryOperator.BeginsWith,filter).GetRemainingAsync();
            var locations = _dynamoMapper.Map<List<DaBeerStorageTable>, List<Location>>(items);

            return locations;
        }

        public async Task<Beer> SaveBeer(string pk,Beer beer)
        {
            beer.BeerId = Guid.NewGuid().ToString();
            var item = DaBeerStorageTable.MapFromBeer(beer,pk);
            
            try
            {
                await _context.SaveAsync(item);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return beer;
        }
        public async Task<Beer> GetBeer(string pk,string id)
        {
            string[] filter = { "Beer" };
            var items = await _context.QueryAsync<DaBeerStorageTable>(pk, QueryOperator.BeginsWith, filter).GetRemainingAsync();
            var beers = _dynamoMapper.Map<List<DaBeerStorageTable>, List<Beer>>(items);

            var beer = _dynamoMapper.Map<Beer>(beers.First(x => x.BeerId == id));

            return beer;  
        }

      
        public async Task<List<Beer>> ListNotDrank(string pk)
        {
            var conditions = new List<ScanCondition>();
            conditions.Add(new ScanCondition("Drank", ScanOperator.NotEqual, true));
            conditions.Add(new ScanCondition("PK", ScanOperator.Equal, pk));
            conditions.Add(new ScanCondition("SK", ScanOperator.BeginsWith, "Beer#"));
            var items = await _context.ScanAsync<DaBeerStorageTable>(conditions).GetRemainingAsync();

            var beers = _dynamoMapper.Map<List<DaBeerStorageTable>, List<Beer>>(items);

            return beers;
        }

        public async Task<List<Beer>> GetBrewery(string pk,string breweryName)
        {
            return await Scan("BreweryName", breweryName);
        }

        private async Task<List<Beer>> Scan(string key, object value)
        {
            var conditions = new List<ScanCondition>();
            conditions.Add(new ScanCondition(key, ScanOperator.NotEqual, value));
            var items = await _context.ScanAsync<DaBeerStorageTable>(conditions).GetRemainingAsync();

            var beers = _dynamoMapper.Map<List<DaBeerStorageTable>, List<Beer>>(items);

            return beers;
        }
    }
}
