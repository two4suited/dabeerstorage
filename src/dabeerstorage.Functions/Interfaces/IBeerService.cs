using System.Collections.Generic;
using System.Threading.Tasks;
using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.ViewModels;

namespace DaBeerStorage.Functions.Interfaces
{
    public interface IBeerService
    {
        Task Drink(Drink drink);
        Task Create(Create newBeer);
        Task<List<BeerViewModel>> ListNotDrank(ListNotDrank listNotDrank);
        Task Move(Move move);
    }
}