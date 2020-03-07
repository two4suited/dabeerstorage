namespace DaBeerStorage.Functions.ApiModels.Beer
{
    public class Create : Models.Beer
    {
        public Create()
        {
            Quantity = "1";
        }
        public string Quantity { get; set; }
        public string UserName { get; set; }
    }
}