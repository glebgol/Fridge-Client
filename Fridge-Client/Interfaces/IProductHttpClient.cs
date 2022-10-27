using Fridge_Client.Models;

namespace Fridge_Client.Interfaces
{
    public interface IProductHttpClient
    {
        Task<ICollection<Product>> GetAllProducts();
        HttpResponseMessage CreateProduct(Product product);
        HttpResponseMessage DeleteProduct(Guid id);
        Task<Product> GetProductById(Guid id);
    }
}