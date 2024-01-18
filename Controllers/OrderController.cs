using Microsoft.AspNetCore.Mvc;

namespace DemoGit.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
