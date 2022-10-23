using Fridge_Client.Models;

namespace Fridge_Client.Interfaces
{
    public interface IFridgeModelHttpClient
    {
        Task<IEnumerable<FridgeModel>> GetAllFridgeModels();
    }
}
