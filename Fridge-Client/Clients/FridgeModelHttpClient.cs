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

        public async Task<HttpResponseMessage> CreateFridgeModel(FridgeModel fridgeModel)
        {
            var result = await _httpClient.PostAsJsonAsync("", fridgeModel);
            return result;
        }

        public async Task<HttpResponseMessage> DeleteFridgeModel(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"{_httpClient.BaseAddress}/{id}");
            return result;
        }

        public async Task<IEnumerable<FridgeModel>> GetAllFridgeModels()
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<FridgeModel>>(_httpClient.BaseAddress);
            return result;
        }

        public async Task<FridgeModel> GetFridgeModel(Guid id)
        {
            var result = await _httpClient.GetFromJsonAsync<FridgeModel>($"{_httpClient.BaseAddress}/{id}");
            return result;
        }

        public async Task<HttpResponseMessage> UpdateFridgeModel(Guid id, FridgeModel fridgeModel)
        {
            var result = await _httpClient.PutAsJsonAsync($"{_httpClient.BaseAddress}/{id}", fridgeModel);
            return result;
        }
    }
}
