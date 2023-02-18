using DevOn.Business.Models;

namespace DevOn.API.Interfaces
{
    public interface IKeyService
    {
        Key GetKey();
        bool IsKeyValid(string submittedKey);
    }
}
