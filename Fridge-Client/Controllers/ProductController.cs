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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                productHttpClient.CreateProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public IActionResult Delete(Guid id)
        {
            var product = productHttpClient.GetProductById(id);
            return View(product.Result);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            productHttpClient.DeleteProduct(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
