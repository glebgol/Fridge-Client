using Fridge_Client.Interfaces;
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
    }
}
