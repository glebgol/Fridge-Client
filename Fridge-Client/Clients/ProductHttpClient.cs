﻿using Fridge_Client.Interfaces;
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
            var result = _httpClient.PostAsJsonAsync<Product>("", product);
            return result.Result;
        }

        public Task<ICollection<Product>> GetAllProducts()
        {
            return _httpClient.GetFromJsonAsync<ICollection<Product>>("");
        }
    }
}
