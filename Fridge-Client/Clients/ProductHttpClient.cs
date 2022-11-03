using Fridge_Client.Interfaces;
using Fridge_Client.Models;

namespace Fridge_Client.Clients
{
    public class ProductHttpClient : IProductHttpClient
    {
        private readonly HttpClient _httpClient;

        public ProductHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> CreateProduct(Product product)
        {
            var result = await _httpClient.PostAsJsonAsync("", product);
            return result;
        }

        public async Task<HttpResponseMessage> DeleteProduct(Guid id)
        {
            var result = await _httpClient.DeleteAsync(_httpClient.BaseAddress + $"/{id}");
            return result;
        }

        public async Task<ICollection<Product>?> GetAllProducts()
        {
            var result = await _httpClient.GetFromJsonAsync<ICollection<Product>>("");
            return result;
        }

        public async Task<Product?> GetProductById(Guid id)
        {
            var result = await _httpClient.GetFromJsonAsync<Product>(_httpClient.BaseAddress + $"/{id}");
            return result;
        }

        public async Task<HttpResponseMessage> UpdateProduct(Guid id, Product product)
        {
            var result = await _httpClient.PutAsJsonAsync(_httpClient.BaseAddress + $"/{id}", product);
            return result;
        }
    }
}
