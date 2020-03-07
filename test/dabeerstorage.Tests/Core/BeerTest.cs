using DaBeerStorage.Functions.Models;
using Shouldly;
using Xunit;

    public class BeerTest
    {
        [Fact]
        public void BeerDrink_WhenDrink_DrankTrue()
        {
            var beer = new Beer();

            beer.Drink();

            beer.Drank.Value.ShouldBeTrue();
        }

        [Fact]
        public void BeerDrink_WhenDrink_LocationNull()
        {
            var beer = new Beer {Location = "test"};

            beer.Drink();

            beer.Location.ShouldBeNull();
        }

        [Fact]
        public void BeerDrink_WhenDrink_DrankWhenNotNull()
        {
            var beer = new Beer();
            beer.Drink();
            beer.DrankWhen.ShouldNotBeNull();
        }

        [Fact]
        public void AddToLocation_WhenAdded_EqualsLocationId()
        {
            var beer = new Beer();
            string locationId = "Test";
            beer.AddToLocation(locationId);

            beer.Location.ShouldBe(locationId);
        }

        [Fact]
        public void GaveAway_InitialNull_ThenTrue()
        {
            var beer = new Beer();

            beer.GaveWay.ShouldBeNull();

            beer.GiveAway();

            beer.GaveWay.Value.ShouldBeTrue();
            beer.Location.ShouldBeNull();   
        }
        [Fact]
        public void ChangeLocation_ShouldBeNewLocation()
        {
            string newLocation ="New";
            var beer = new Beer();
            beer.Location="Old";

            beer.ChangeLocation(newLocation);

            beer.Location.ShouldBe(newLocation);

        }

    }

