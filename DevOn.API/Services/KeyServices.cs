using DevOn.API.Interfaces;
using DevOn.Business.Models;

namespace DevOn.API.Services
{
    public class KeyServices:IKeyService
    {
        private readonly Key _key;
        public KeyServices(IConfiguration configuration) {
            _key.Value=configuration.GetValue<string>("X-API-KEY");
        }    
        public Key GetKey()
        {
            return _key;
        }
        public  bool IsKeyValid(string submittedKey)
        {
            return _key.Value.Equals(submittedKey);
        }

    }
   
}
