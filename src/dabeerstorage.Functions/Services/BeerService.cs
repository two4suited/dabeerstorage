using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Interfaces;
using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.Services
{
    public class BeerService : IBeerService
    {
        private readonly IDaBeerStorageRepository _daBeerStorageRepository;
 
        public BeerService(IDaBeerStorageRepository daBeerStorageRepository)
        {
            _daBeerStorageRepository = daBeerStorageRepository;
        }
        public async Task Drink(Drink drink)
        {
            var beer = await _daBeerStorageRepository.GetBeer(drink.UserName,drink.BeerId);
            beer.Drink();
            await _daBeerStorageRepository.SaveBeer(drink.UserName,beer);
        }

        public async Task Create(Create newBeer)
        {
            var qty = Convert.ToInt32(newBeer.Quantity);

            for (var i = 1; i <= qty; i++)
            {
                var beer = ApiModels.Beer.Create.MapFromCreate(newBeer);
                await _daBeerStorageRepository.SaveBeer(newBeer.UserName,beer);
            }
        }

        public async Task<ListNotDrank> ListNotDrank(ListNotDrank listNotDrank)
        {
            var beersFromRepo = await _daBeerStorageRepository.ListNotDrank(listNotDrank.UserName);
            listNotDrank.Beers = beersFromRepo;
                
            return listNotDrank;
        }

        public async Task Move(Move move)
        {
            await _daBeerStorageRepository.SaveBeer(move.UserName, move.Beer);
        }
    }
}