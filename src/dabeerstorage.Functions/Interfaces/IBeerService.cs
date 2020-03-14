using System.Threading.Tasks;
using DaBeerStorage.Functions.ApiModels.Beer;

namespace DaBeerStorage.Functions.Interfaces
{
    public interface IBeerService
    {
        Task Drink(Drink drink);
        Task Create(Create newBeer);
        Task<ListNotDrank> ListNotDrank(ListNotDrank listNotDrank);
        Task Move(Move move);
    }
}