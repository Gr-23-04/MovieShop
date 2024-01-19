using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieShop.Data;


namespace MovieShop.Controllers
{
    public class CustomersController : Controller
    {
        private readonly MovieShopDbContext _context;

        public CustomersController(MovieShopDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers.ToListAsync());
        }

    }
}