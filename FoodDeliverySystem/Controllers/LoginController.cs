using Microsoft.AspNetCore.Mvc;

namespace FoodDeliverySystem.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
