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

        public HttpResponseMessage CreateProduct(Product product)
        {
            var result = _httpClient.PostAsJsonAsync("", product);
            return result.Result;
        }

        public HttpResponseMessage DeleteProduct(Guid id)
        {
            var result = _httpClient.DeleteAsync(_httpClient.BaseAddress + $"/{id}");
            return result.Result;
        }

        public Task<ICollection<Product>> GetAllProducts()
        {
            var result = _httpClient.GetFromJsonAsync<ICollection<Product>>("");
            return result;
        }

        public Task<Product> GetProductById(Guid id)
        {
            var result = _httpClient.GetFromJsonAsync<Product>(_httpClient.BaseAddress + $"/{id}");
            return result;
        }
    }
}
