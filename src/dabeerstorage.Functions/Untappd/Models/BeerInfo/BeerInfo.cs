using System;
using Newtonsoft.Json;

namespace DaBeerStorage.Functions.Untappd.Models.BeerInfo
{
    public partial class BeerHeader {
        [JsonProperty("beer")]
        public Beer Beer { get;
            set; }
    }

    public partial class Beer {
        [JsonProperty("bid")]
        public long Bid { get;
            set; }

        [JsonProperty("beer_name")]
        public string BeerName { get;
            set; }

        [JsonProperty("beer_label")]
        public Uri BeerLabel { get;
            set; }

        [JsonProperty("beer_abv")]
        public double BeerAbv { get;
            set; }

        [JsonProperty("beer_ibu")]
        public long BeerIbu { get;
            set; }

        [JsonProperty("beer_description")]
        public string BeerDescription { get;
            set; }

        [JsonProperty("beer_style")]
        public string BeerStyle { get;
            set; }

        [JsonProperty("is_in_production")]
        public long IsInProduction { get;
            set; }

        [JsonProperty("beer_slug")]
        public string BeerSlug { get;
            set; }

        [JsonProperty("is_homebrew")]
        public long IsHomebrew { get;
            set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get;
            set; }

        [JsonProperty("rating_count")]
        public long RatingCount { get;
            set; }

        [JsonProperty("rating_score")]
        public double RatingScore { get;
            set; }

        [JsonProperty("stats")]
        public Stats Stats { get;
            set; }

        [JsonProperty("brewery")]
        public Brewery Brewery { get;
            set; }

        [JsonProperty("auth_rating")]
        public long AuthRating { get;
            set; }

        [JsonProperty("wish_list")]
        public bool WishList { get;
            set; }

        [JsonProperty("media")]
        public Media Media { get;
            set; }

        [JsonProperty("similar")]
        public Similar Similar { get;
            set; }

        [JsonProperty("friends")]
        public Friends Friends { get;
            set; }

        [JsonProperty("vintages")]
        public Friends Vintages { get;
            set; }
    }

    public partial class Brewery {
        [JsonProperty("brewery_id")]
        public long BreweryId { get;
            set; }

        [JsonProperty("brewery_name")]
        public string BreweryName { get;
            set; }

        [JsonProperty("brewery_label")]
        public Uri BreweryLabel { get;
            set; }

        [JsonProperty("country_name")]
        public string CountryName { get;
            set; }

        [JsonProperty("contact")]
        public BreweryContact Contact { get;
            set; }

        [JsonProperty("location")]
        public BreweryLocation Location { get;
            set; }

        [JsonProperty("brewery_slug", NullValueHandling = NullValueHandling.Ignore)]
        public string BrewerySlug { get;
            set; }

        [JsonProperty("brewery_active", NullValueHandling = NullValueHandling.Ignore)]
        public long ? BreweryActive { get;
            set; }
    }

    public partial class BreweryContact {
        [JsonProperty("twitter")]
        public string Twitter { get;
            set; }

        [JsonProperty("facebook")]
        public Uri Facebook { get;
            set; }

        [JsonProperty("url")]
        public Uri Url { get;
            set; }

        [JsonProperty("instagram", NullValueHandling = NullValueHandling.Ignore)]
        public string Instagram { get;
            set; }
    }

    public partial class BreweryLocation {
        [JsonProperty("brewery_city")]
        public string BreweryCity { get;
            set; }

        [JsonProperty("brewery_state")]
        public string BreweryState { get;
            set; }

        [JsonProperty("lat")]
        public double Lat { get;
            set; }

        [JsonProperty("lng")]
        public double Lng { get;
            set; }
    }

    public partial class Friends {
        [JsonProperty("items")]
        public Item[] Items { get;
            set; }

        [JsonProperty("count")]
        public long Count { get;
            set; }
    }

    public partial class Item {
        [JsonProperty("category_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get;
            set; }

        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryId { get;
            set; }

        [JsonProperty("is_primary", NullValueHandling = NullValueHandling.Ignore)]
        public bool ? IsPrimary { get;
            set; }

        [JsonProperty("beer", NullValueHandling = NullValueHandling.Ignore)]
        public ItemBeer Beer { get;
            set; }
    }

    public partial class ItemBeer {
        [JsonProperty("bid")]
        public long Bid { get;
            set; }

        [JsonProperty("beer_label")]
        public Uri BeerLabel { get;
            set; }

        [JsonProperty("beer_slug")]
        public string BeerSlug { get;
            set; }

        [JsonProperty("beer_name")]
        public string BeerName { get;
            set; }

        [JsonProperty("is_vintage")]
        public long IsVintage { get;
            set; }

        [JsonProperty("is_variant")]
        public long IsVariant { get;
            set; }
    }

    public partial class Media {
        [JsonProperty("count")]
        public long Count { get;
            set; }

        [JsonProperty("items")]
        public MediaItems Items { get;
            set; }
    }

    public partial class MediaItems {
        [JsonProperty("photo_id")]
        public long PhotoId { get;
            set; }

        [JsonProperty("photo")]
        public Photo Photo { get;
            set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get;
            set; }

        [JsonProperty("checkin_id")]
        public long CheckinId { get;
            set; }

        [JsonProperty("beer")]
        public PurpleBeer Beer { get;
            set; }

        [JsonProperty("brewery")]
        public Brewery Brewery { get;
            set; }

        [JsonProperty("user")]
        public User User { get;
            set; }

        [JsonProperty("venue")]
        public Venue[] Venue { get;
            set; }
    }

    public partial class PurpleBeer {
        [JsonProperty("bid")]
        public long Bid { get;
            set; }

        [JsonProperty("beer_name")]
        public string BeerName { get;
            set; }

        [JsonProperty("beer_label")]
        public Uri BeerLabel { get;
            set; }

        [JsonProperty("beer_abv")]
        public double BeerAbv { get;
            set; }

        [JsonProperty("beer_ibu")]
        public long BeerIbu { get;
            set; }

        [JsonProperty("beer_slug")]
        public string BeerSlug { get;
            set; }

        [JsonProperty("beer_description")]
        public string BeerDescription { get;
            set; }

        [JsonProperty("is_in_production")]
        public long IsInProduction { get;
            set; }

        [JsonProperty("beer_style_id")]
        public long BeerStyleId { get;
            set; }

        [JsonProperty("beer_style")]
        public string BeerStyle { get;
            set; }

        [JsonProperty("auth_rating")]
        public long AuthRating { get;
            set; }

        [JsonProperty("wish_list")]
        public bool WishList { get;
            set; }

        [JsonProperty("beer_active")]
        public long BeerActive { get;
            set; }
    }

    public partial class Photo {
        [JsonProperty("photo_img_sm")]
        public Uri PhotoImgSm { get;
            set; }

        [JsonProperty("photo_img_md")]
        public Uri PhotoImgMd { get;
            set; }

        [JsonProperty("photo_img_lg")]
        public Uri PhotoImgLg { get;
            set; }

        [JsonProperty("photo_img_og")]
        public Uri PhotoImgOg { get;
            set; }
    }

    public partial class User {
        [JsonProperty("uid")]
        public long Uid { get;
            set; }

        [JsonProperty("user_name")]
        public string UserName { get;
            set; }

        [JsonProperty("first_name")]
        public string FirstName { get;
            set; }

        [JsonProperty("last_name")]
        public string LastName { get;
            set; }

        [JsonProperty("user_avatar")]
        public Uri UserAvatar { get;
            set; }

        [JsonProperty("relationship")]
        public string Relationship { get;
            set; }

        [JsonProperty("is_private")]
        public long IsPrivate { get;
            set; }
    }

    public partial class Venue {
        [JsonProperty("venue_id")]
        public long VenueId { get;
            set; }

        [JsonProperty("venue_name")]
        public string VenueName { get;
            set; }

        [JsonProperty("primary_category")]
        public string PrimaryCategory { get;
            set; }

        [JsonProperty("parent_category_id")]
        public string ParentCategoryId { get;
            set; }

        [JsonProperty("categories")]
        public Friends Categories { get;
            set; }

        [JsonProperty("location")]
        public VenueLocation Location { get;
            set; }

        [JsonProperty("contact")]
        public VenueContact Contact { get;
            set; }

        [JsonProperty("private_venue")]
        public bool PrivateVenue { get;
            set; }

        [JsonProperty("foursquare")]
        public Foursquare Foursquare { get;
            set; }

        [JsonProperty("venue_icon")]
        public VenueIcon VenueIcon { get;
            set; }
    }

    public partial class VenueContact {
        [JsonProperty("twitter")]
        public string Twitter { get;
            set; }

        [JsonProperty("venue_url")]
        public string VenueUrl { get;
            set; }
    }

    public partial class Foursquare {
        [JsonProperty("foursquare_id")]
        public string FoursquareId { get;
            set; }

        [JsonProperty("foursquare_url")]
        public Uri FoursquareUrl { get;
            set; }
    }

    public partial class VenueLocation {
        [JsonProperty("venue_address")]
        public string VenueAddress { get;
            set; }

        [JsonProperty("venue_city")]
        public string VenueCity { get;
            set; }

        [JsonProperty("venue_state")]
        public string VenueState { get;
            set; }

        [JsonProperty("lat")]
        public double Lat { get;
            set; }

        [JsonProperty("lng")]
        public double Lng { get;
            set; }
    }

    public partial class VenueIcon {
        [JsonProperty("sm")]
        public Uri Sm { get;
            set; }

        [JsonProperty("md")]
        public Uri Md { get;
            set; }

        [JsonProperty("lg")]
        public Uri Lg { get;
            set; }
    }

    public partial class Similar {
        [JsonProperty("count")]
        public long Count { get;
            set; }

        [JsonProperty("items")]
        public SimilarItems Items { get;
            set; }
    }

    public partial class SimilarItems {
        [JsonProperty("rating_score")]
        public double RatingScore { get;
            set; }

        [JsonProperty("beer")]
        public FluffyBeer Beer { get;
            set; }

        [JsonProperty("brewery")]
        public Brewery Brewery { get;
            set; }

        [JsonProperty("friends")]
        public Friends Friends { get;
            set; }
    }

    public partial class FluffyBeer {
        [JsonProperty("bid")]
        public long Bid { get;
            set; }

        [JsonProperty("beer_name")]
        public string BeerName { get;
            set; }

        [JsonProperty("beer_abv")]
        public double BeerAbv { get;
            set; }

        [JsonProperty("beer_ibu")]
        public long BeerIbu { get;
            set; }

        [JsonProperty("beer_style")]
        public string BeerStyle { get;
            set; }

        [JsonProperty("beer_label")]
        public Uri BeerLabel { get;
            set; }

        [JsonProperty("auth_rating")]
        public long AuthRating { get;
            set; }

        [JsonProperty("wish_list")]
        public bool WishList { get;
            set; }
    }

    public partial class Stats {
        [JsonProperty("total_count")]
        public long TotalCount { get;
            set; }

        [JsonProperty("monthly_count")]
        public long MonthlyCount { get;
            set; }

        [JsonProperty("total_user_count")]
        public long TotalUserCount { get;
            set; }

        [JsonProperty("user_count")]
        public long UserCount { get;
            set; }
    }

    
}