using Fridge_Client.Models;

namespace Fridge_Client.Interfaces
{
    public interface IFridgeModelHttpClient
    {
        Task<IEnumerable<FridgeModel>> GetAllFridgeModels();
        Task<FridgeModel> GetFridgeModel(Guid id);

        Task<HttpResponseMessage> CreateFridgeModel(FridgeModel fridgeModel);

        Task<HttpResponseMessage> DeleteFridgeModel(Guid id);

        Task<HttpResponseMessage> UpdateFridgeModel(Guid id, FridgeModel fridgeModel);
    }
}
