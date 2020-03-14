using DaBeerStorage.Functions.Models;

namespace DaBeerStorage.Functions.ViewModels
{
    public class LocationViewModel
    {
        public string Name { get; set; }
        public static LocationViewModel FromCoreModel(Location location)
        {
            return new LocationViewModel()
            {
                Name = location.Name
            };
        }
    }
}