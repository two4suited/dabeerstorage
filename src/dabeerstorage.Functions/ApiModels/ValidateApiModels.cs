using System.Collections.Generic;

namespace DaBeerStorage.Functions.ApiModels
{
    public abstract class ValidateApiModels
    {
        public ValidateApiModels()
        {
            ErrorList = new List<string>();
        }

        public abstract void Validate();

        public List<string> ErrorList { get; set; }
        public bool Valid => ErrorList.Count == 0;

    }
}