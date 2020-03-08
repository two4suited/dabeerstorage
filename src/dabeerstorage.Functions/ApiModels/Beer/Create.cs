using System;
using System.Security.Principal;

namespace DaBeerStorage.Functions.ApiModels.Beer
{
    public class Create
    {
        public Create()
        {
            Quantity = "1";
            CreateDate = DateTimeOffset.Now;
        }
        public string Quantity { get; set; }
        public string UserName { get; set; }
        public DateTimeOffset CreateDate { get; set; }

        public string BeerName { get; set; }

        public static Models.Beer MapFromCreate(Create create)
        {
            return new Models.Beer()
            {
                Name = create.BeerName,
                DateAdded = create.CreateDate
            };
        }
    }
}