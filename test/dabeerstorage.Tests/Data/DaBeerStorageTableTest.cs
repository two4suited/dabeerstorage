using System;
using AutoFixture.Xunit2;
using DaBeerStorage.Functions.Data;
using DaBeerStorage.Functions.Models;
using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.Data
{
    public class DaBeerStorageTableTest
    {
        [Theory, AutoData]
        public void ShouldMapField_WhenMapFromBeer(string pk,Beer beer)
        {
            var table =DaBeerStorageTable.MapFromBeer(beer,pk);
            
            table.PK.ShouldBe(pk);
            table.SK.ShouldBe($"Beer#{beer.BeerId}");
            table.BreweryKey.ShouldBe("Brewery#" + beer.BreweryName + "#" + beer.BeerId);
            table.Drank.ShouldBe(beer.Drank);
            table.Ibu.ShouldBe(beer.Ibu);
            table.Rating.ShouldBe(beer.Rating);
            table.Style.ShouldBe(beer.Style);
            table.BeerDescription.ShouldBe(beer.Description);
            table.BeerName.ShouldBe(beer.Name);
            table.BreweryName.ShouldBe(beer.BreweryName);
            table.BreweryState.ShouldBe(beer.BreweryState);
            table.DateAdded.ShouldBe(beer.DateAdded.ToString());
            table.DrankWhen.ShouldBe(beer.DrankWhen);
            table.LabelPath.ShouldBe(beer.LabelPath);
            table.LocationName.ShouldBe(beer.Location);
            table.UntappedId.ShouldBe(beer.UntappedId);
            table.AlchoholByVolume.ShouldBe(beer.AlchoholByVolume);
            table.BrewerDbId.ShouldBe(beer.BrewerDbId);
        }

        [Theory, AutoData]
        public void ShouldMapFields_WhenMapFromTable(DaBeerStorageTable table)
        {
            table.DateAdded = DateTimeOffset.Now.ToString();
            
            var beer = DaBeerStorageTable.MapFromTable(table);
            
            beer.Description.ShouldBe(table.BeerDescription);
            beer.Drank.ShouldBe(table.Drank);
            beer.Ibu.ShouldBe(table.Ibu);
            beer.Location.ShouldBe(table.LocationName);
            beer.Name.ShouldBe(table.BeerName);
            beer.Rating.ShouldBe(table.Rating);
            beer.Style.ShouldBe(table.Style);
            beer.BeerId.ShouldBe(table.BeerId);
            beer.BreweryName.ShouldBe(table.BreweryName);
            beer.BreweryState.ShouldBe(table.BreweryState);
            beer.DateAdded.ShouldBe(DateTimeOffset.Parse(table.DateAdded));
            beer.DrankWhen.ShouldBe(table.DrankWhen);
            beer.LabelPath.ShouldBe(table.LabelPath);
            beer.Location.ShouldBe(table.LocationName);
            beer.UntappedId.ShouldBe(table.UntappedId);
            beer.AlchoholByVolume.ShouldBe(table.AlchoholByVolume);
            beer.BrewerDbId.ShouldBe(table.BrewerDbId);
        }
    }
}