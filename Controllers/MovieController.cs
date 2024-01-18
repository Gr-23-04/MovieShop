using Microsoft.AspNetCore.Mvc;

namespace DemoGit.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
