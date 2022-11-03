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

        public async Task<IActionResult> Index()
        {
            var result = await productHttpClient.GetAllProducts();
            return View(result);
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
                await productHttpClient.CreateProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var product = await productHttpClient.GetProductById(id);
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await productHttpClient.DeleteProduct(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid id, Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await productHttpClient.UpdateProduct(id, product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }
    }
}
