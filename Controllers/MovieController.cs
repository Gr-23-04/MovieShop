using Microsoft.AspNetCore.Mvc;
using MovieShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using MovieShop.Data;

namespace MovieShop.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SubmitMovie()
        {
            return View();
        }

        private readonly MovieShopDbContext _context; 

        public MovieController(MovieShopDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Movie movie) //Creates new Movie. See Submission form in Views/Movie/SubmitMovie
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Movie submitted successfully!"; //Sends message if succesful

                return RedirectToAction("SubmitMovie");
            }

            TempData["FailMessage"] = "Movie could not be submitted."; //Sends fail-message is unsuccesful
            return View("SubmitMovie", movie);
        }

    }


}
