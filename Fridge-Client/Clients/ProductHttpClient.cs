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
            var result = await _httpClient.PostAsJsonAsync<Product>("", product);
            return result;
        }

        public Task<ICollection<Product>> GetAllProducts()
        {
            return _httpClient.GetFromJsonAsync<ICollection<Product>>("");
        }
    }
}
