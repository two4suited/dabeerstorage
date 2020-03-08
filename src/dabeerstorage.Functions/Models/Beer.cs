using System;

namespace DaBeerStorage.Functions.Models
{
    public class Beer 
    {
        public Beer()
        {
            Drank = null;
            DrankWhen = null;
        }

        public string BeerId { get; set; }
       
        public string Name { get; set; }
        public string UntappedId { get; set; }
        public string AlchoholByVolume { get; set; }
        public string Description { get; set; }
        public string LabelPath { get; set; }
        public string Style { get; set; }
        public string Ibu { get; set; }
        public string BrewerDbId { get; set; }
        public bool? Drank { get; set; }
        public string Rating { get; set; }
        public string DrankWhen { get; set; }
        public DateTimeOffset DateAdded { get; set; }
        public string Location { get; set; }
        public string BreweryName { get; set; }
        public string BreweryState { get; set; }
        public bool? GaveWay { get;set; }


        public void Drink()
        {
            Drank = true;
            DrankWhen=DateTimeOffset.Now.ToString();
            Location = null;
        }

        public void AddToLocation(string location)
        {
            Location = location;
        }

        public void GiveAway()
        {
            GaveWay = true;
            Location = null;
        }

        public void ChangeLocation(string newLocaton)
        {
            Location = newLocaton;
        }
       
    }
}
