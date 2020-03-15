using System.Collections.Generic;
using System.Linq;
using DaBeerStorage.Functions.Models;
using FluentValidation.Resources;

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

        public static List<LocationViewModel> FromCoreModels(List<Location> rows)
        {
            return rows.Select(LocationViewModel.FromCoreModel).ToList();
        }
    
}
}