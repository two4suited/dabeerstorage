using System.Collections.Generic;
using System.Threading.Tasks;
using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.Interfaces
{
    public interface IBeerService
    {
        Task Drink(Drink drink);
        Beer Create(Create newBeer);
        List<ListNotDrank> ListNotDrank();
        Task Move(Move move);
    }
}