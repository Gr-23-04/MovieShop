using Microsoft.AspNetCore.Mvc;

namespace DemoGit.Controllers
{
    public class CustomersController : Controller
    {
        private readonly DbContext _context;

        public CustomersController(DbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers.ToListAsync());
        }

    }
}