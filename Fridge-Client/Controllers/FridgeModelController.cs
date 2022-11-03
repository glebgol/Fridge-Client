using Fridge_Client.Interfaces;
using Fridge_Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fridge_Client.Controllers
{
    public class FridgeModelController : Controller
    {
        private readonly IFridgeModelHttpClient fridgeHttpClient;

        public FridgeModelController(IFridgeModelHttpClient fridgeHttpClient)
        {
            this.fridgeHttpClient = fridgeHttpClient;
        }

        public async Task<IActionResult> Index()
        {
            var result = await fridgeHttpClient.GetAllFridgeModels();
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
                await fridgeHttpClient.CreateFridgeModel(fridgeModel);
                return RedirectToAction(nameof(Index));
            }
            return View(fridgeModel);
        }
    }
}
