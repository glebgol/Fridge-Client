using Fridge_Client.Interfaces;
using Fridge_Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fridge_Client.Controllers
{
    public class FridgeModelController : Controller
    {
        private readonly IFridgeModelHttpClient fridgeModelHttpClient;

        public FridgeModelController(IFridgeModelHttpClient fridgeModelHttpClient)
        {
            this.fridgeModelHttpClient = fridgeModelHttpClient;
        }

        public async Task<IActionResult> Index()
        {
            var result = await fridgeModelHttpClient.GetAllFridgeModels();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(FridgeModel fridgeModel)
        {
            if (ModelState.IsValid)
            {
                await fridgeModelHttpClient.CreateFridgeModel(fridgeModel);
                return RedirectToAction(nameof(Index));
            }
            return View(fridgeModel);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await fridgeModelHttpClient.GetFridgeModel(id);
            return View(result);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await fridgeModelHttpClient.DeleteFridgeModel(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
