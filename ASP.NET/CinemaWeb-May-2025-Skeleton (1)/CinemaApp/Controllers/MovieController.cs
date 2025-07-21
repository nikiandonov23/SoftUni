using CinemaApp.Data;
using CinemaApp.Web.ViewModels.Movie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CinemaApp.Services.Core;
using CinemaApp.Services.Core.Interfaces;

namespace CinemaApp.Web.Controllers
{
    public class MovieController(IMovieService movieService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var allMovies = await movieService.GetAllMoviesAsync();

            return View(allMovies);
        }
    }


}
