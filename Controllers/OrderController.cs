using Microsoft.AspNetCore.Mvc;

namespace MovieShop.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
