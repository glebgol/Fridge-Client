using Fridge_Client.Interfaces;
using Fridge_Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fridge_Client.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductHttpClient productHttpClient;

        public ProductController(IProductHttpClient productHttpClient)
        {
            this.productHttpClient = productHttpClient;
        }

        public IActionResult Index()
        {
            var result = productHttpClient.GetAllProducts();
            var lst = result.Result;
            return View(lst);
        }

        public IActionResult Create(Product product)
        {
            productHttpClient.CreateProduct(product);
            return View(product);
        }
    }
}
