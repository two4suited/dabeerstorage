using System;
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

        public static Beer MapFromTable(DaBeerStorageTable table)
        {
            return new Beer()
            {
                Description = table.BeerDescription,
                Drank = table.Drank,
                Ibu = table.Ibu,
                Location = table.LocationName,
                Name = table.BeerName,
                Rating = table.Rating,
                Style = table.Style,
                BeerId = table.BeerId,
                BreweryName = table.BreweryName,
                BreweryState = table.BreweryState,
                DateAdded = DateTimeOffset.Parse(table.DateAdded),
                DrankWhen = table.DrankWhen,
                LabelPath = table.LabelPath,
                UntappedId = table.UntappedId,
                AlchoholByVolume = table.AlchoholByVolume,
                BrewerDbId = table.BrewerDbId
            };
        }
    }
}
