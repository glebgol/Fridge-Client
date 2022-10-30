using Fridge_Client.Models;

namespace Fridge_Client.Interfaces
{
    public interface IProductHttpClient
    {
        Task<ICollection<Product>?> GetAllProducts();
        Task<Product?> GetProductById(Guid id);

        Task<HttpResponseMessage> CreateProduct(Product product);

        Task<HttpResponseMessage> DeleteProduct(Guid id);

        Task<HttpResponseMessage> UpdateProduct(Guid id, Product product);
    }
}