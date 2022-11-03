using Fridge_Client.Interfaces;
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
    }
}
