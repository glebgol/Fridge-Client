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

        public IActionResult Index()
        {
            var result = fridgeHttpClient.GetAllFridgeModels();
            var lst = result.Result;
            return View(lst);
        }
    }
}
