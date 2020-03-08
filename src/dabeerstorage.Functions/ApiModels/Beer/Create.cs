using System;
using System.Collections.Generic;
using System.Security.Principal;
using DaBeerStorage.Functions.ApiModels.Location;

namespace DaBeerStorage.Functions.ApiModels.Beer
{
    public class Create : ValidateApiModels
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
        public string AlchoholByVolume { get; set; } 
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

        public override void Validate()
        {
            if(string.IsNullOrEmpty(UserName)) AddErrorListString(nameof(UserName));
            if(string.IsNullOrEmpty(BeerName)) AddErrorListString(nameof(BeerName));
            if(string.IsNullOrEmpty(Description)) AddErrorListString(nameof(Description));
            if(string.IsNullOrEmpty(Ibu)) AddErrorListString(nameof(Ibu));
            if(Quantity <= 0) ErrorList.Add("Quantity must be greater than 0");    
            if(CreateDate == DateTimeOffset.MinValue) ErrorList.Add("CreateDate can't be default value");
        }

        private void AddErrorListString(string propertyName)
        {
            ErrorList.Add($"{propertyName} can't be blank or null");
        }
        
        
    }
}