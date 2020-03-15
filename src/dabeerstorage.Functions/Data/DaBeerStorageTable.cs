using System;
using System.Collections.Generic;
using System.Linq;
using Amazon.DynamoDBv2.DataModel;
using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.Data
{
    [DynamoDBTable("DaBeerStorage")]
    public  class DaBeerStorageTable
    {
        [DynamoDBHashKey]
        public string PK { get; set; }

        [DynamoDBRangeKey] public string SK { get; set; }

       

        public string LocationName { get; set; }
        public string BeerId { get; set; }

        public string BeerName { get; set; }
        public string UntappedId { get; set; }
        public string AlchoholByVolume { get; set; }
        public string BeerDescription { get; set; }
        public string LabelPath { get; set; }
        public string Style { get; set; }
        public string Ibu { get; set; }
        public string BrewerDbId { get; set; }
        public bool? Drank { get; set; }
        public string Rating { get; set; }
        public string DrankWhen { get; set; }
        public string DateAdded { get; set; }
        public string BreweryName { get; set; }
        public string BreweryState { get; set; }
        [DynamoDBLocalSecondaryIndexRangeKey]
        public string BreweryKey { get; set; }

        public static DaBeerStorageTable MapFromBeer(Beer beer,string pk)
        {
            return new DaBeerStorageTable()
            {
                PK = pk,
                SK = "Beer#"+beer.BeerId,
                BreweryKey = "Brewery#" + beer.BreweryName + "#" + beer.BeerId,
                Drank = beer.Drank,
                Ibu = beer.Ibu,
                Rating = beer.Rating,
                Style = beer.Style,
                BeerDescription = beer.Description,
                BeerId = beer.BeerId,
                BeerName = beer.Name,
                BreweryName = beer.BreweryName,
                BreweryState = beer.BreweryState,
                DateAdded = beer.DateAdded.ToString(),
                DrankWhen = beer.DrankWhen,
                LabelPath = beer.LabelPath,
                LocationName = beer.Location,
                UntappedId = beer.UntappedId,
                AlchoholByVolume = beer.AlchoholByVolume,
                BrewerDbId = beer.BrewerDbId
            };
        }

        public Beer MapToBeer()
        {
            return new Beer()
            {
                Description = BeerDescription,
                Drank =Drank,
                Ibu = Ibu,
                Location = LocationName,
                Name = BeerName,
                Rating = Rating,
                Style =Style,
                BeerId = BeerId,
                BreweryName = BreweryName,
                BreweryState = BreweryState,
                DateAdded = DateTimeOffset.Parse(DateAdded),
                DrankWhen = DrankWhen,
                LabelPath = LabelPath,
                UntappedId = UntappedId,
                AlchoholByVolume = AlchoholByVolume,
                BrewerDbId = BrewerDbId
            };
        }

        public static List<Beer> MapToBeers(List<DaBeerStorageTable> rows)
        {
            return rows.Select(row => row.MapToBeer()).ToList();
        }

        public static List<Location> MapToLocations(List<DaBeerStorageTable> rows)
        {
            return rows.Select(row => row.MapToLocation()).ToList();
        }
        
        public Location MapToLocation()
        {
            return new Location()
            {
                Name = LocationName
            };
        }

        public static DaBeerStorageTable MapFromLocation(Location location,string pk)
        {
            return new DaBeerStorageTable()
            {
                PK = pk,
                SK = $"Location#{location.Name}",
                LocationName = location.Name

            };
        }
    }
}
