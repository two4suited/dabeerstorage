namespace DaBeerStorage.Functions.ApiModels.Location
{
    public class Add 
    {
        public string Name { get; set; }
        public string UserName { get; set; }

        public Models.Location ToCoreModel()
        {
            return new Models.Location()
            {
                Name = Name
            };
        }
    }
    
    
}