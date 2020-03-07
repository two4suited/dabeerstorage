using Amazon.DynamoDBv2.DataModel;

namespace DaBeerStorage.Functions.Data
{
    [DynamoDBTable("DaBeerStorage")]
    public class DaBeerStorageTable
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
    }
}
