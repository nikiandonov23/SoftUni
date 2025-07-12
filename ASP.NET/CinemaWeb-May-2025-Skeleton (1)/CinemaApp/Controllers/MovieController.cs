using CinemaApp.Data;
using CinemaApp.Web.ViewModels.Movie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CinemaApp.Web.Controllers
{
    public class MovieController : Controller
    {
        private readonly CinemaAppMay2025DbContext _context;
        public MovieController(CinemaAppMay2025DbContext context)
        {
            _context = context;
        }



        public async Task <IActionResult> Index()
        {
            var movies = await _context.Movies
                .Select(x=>new AllMoviesIndexViewModel
                {
                    Id = x.Id.ToString(),
                    Title = x.Title,
                    Genre = x.Genre,
                    Director = x.Director,
                    ReleaseDate = x.ReleaseDate.ToString("yyyy-MM-dd"),
                    ImageUrl = x.ImageUrl
                })
                .ToListAsync();
            return View(movies);
        }
    }
}
