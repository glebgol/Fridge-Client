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

        public Task<HttpResponseMessage> CreateProduct(Product product)
        {
            var result = _httpClient.PostAsJsonAsync("", product);
            return result;
        }

        public Task<HttpResponseMessage> DeleteProduct(Guid id)
        {
            var result = _httpClient.DeleteAsync(_httpClient.BaseAddress + $"/{id}");
            return result;
        }

        public Task<ICollection<Product>?> GetAllProducts()
        {
            var result = _httpClient.GetFromJsonAsync<ICollection<Product>>("");
            return result;
        }

        public Task<Product?> GetProductById(Guid id)
        {
            var result = _httpClient.GetFromJsonAsync<Product>(_httpClient.BaseAddress + $"/{id}");
            return result;
        }

        public Task<HttpResponseMessage> UpdateProduct(Guid id, Product product)
        {
            var result = _httpClient.PutAsJsonAsync(_httpClient.BaseAddress + $"/{id}", new { Name = product.Name, DefaultQuantity = product.DefaultQuantity });
            return result;
        }
    }
}
