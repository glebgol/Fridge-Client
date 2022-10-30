using Fridge_Client.Interfaces;
using Fridge_Client.Models;

namespace Fridge_Client.Clients
{
    public class FridgeModelHttpClient : IFridgeModelHttpClient
    {
        private readonly HttpClient _httpClient;

        public FridgeModelHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<HttpResponseMessage> CreateFridgeModel(FridgeModel fridgeModel)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> DeleteFridgeModel(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FridgeModel>> GetAllFridgeModels()
        {
            return _httpClient.GetFromJsonAsync<IEnumerable<FridgeModel>>(_httpClient.BaseAddress);
        }

        public Task<FridgeModel> GetFridgeModel(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> UpdateFridgeModel(Guid id, FridgeModel fridgeModel)
        {
            throw new NotImplementedException();
        }
    }
}
