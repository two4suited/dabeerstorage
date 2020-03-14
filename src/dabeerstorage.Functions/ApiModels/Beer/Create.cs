using System;

namespace DaBeerStorage.Functions.ApiModels.Beer
{
    public class Create 
    {
        public Create()
        {
            Quantity = 1;
            CreateDate = DateTimeOffset.Now;
        }
        public int Quantity { get; set; }
        public string UserName { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public string BeerId { get; set; }
        public string UntappedId { get; set; }
        public string AlcoholByVolume { get; set; } 
        public string Description { get; set; }
        public string LabelPath { get; set; }
        public string Style { get; set; }
        public string Ibu { get; set; }
        public string Location { get; set; }
        public string BreweryName { get; set; }
        public string BreweryState { get; set; }
        public string BeerName { get; set; }

        public static Models.Beer MapFromCreate(Create create)
        {
            return new Models.Beer()
            {
                Name = create.BeerName,
                DateAdded = create.CreateDate
            };
        }
        
        
        
    }
}