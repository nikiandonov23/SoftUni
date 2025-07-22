

using CinemaApp.Data;
using CinemaApp.Data.Models;
using CinemaApp.Services.Core.Interfaces;
using CinemaApp.Web.ViewModels.Movie;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Microsoft.IdentityModel.Tokens;
using static CinemaApp.GCommon.ApplicationConstants;
namespace CinemaApp.Services.Core;

public class MovieService(CinemaAppMay2025DbContext context):IMovieService
{
    public async Task<IEnumerable<AllMoviesIndexViewModel>> GetAllMoviesAsync()
    {
        var allMovies = await context.Movies
            .AsNoTracking()
            .Select(x => new AllMoviesIndexViewModel()
            {
                Director = x.Director,
                Genre = x.Genre,
                Id = x.Id.ToString(),
                ImageUrl = x.ImageUrl,
                ReleaseDate = x.ReleaseDate.ToString(AppDateFormat),
                Title = x.Title
            }).ToListAsync();


        foreach (var movie in allMovies)
        {
            if (movie.ImageUrl.IsNullOrEmpty())
            {
                
                movie.ImageUrl = "/images/no-image.jpg"; // ✅ валиден URL за браузъра

            }
        }

        return allMovies;
    }

    public async Task AddAsync(MovieFormViewModel viewModel)
    {
        Movie newMovie = new Movie()
        {
            Genre = viewModel.Genre,
            Description = viewModel.Description,
            Director = viewModel.Director,
            Duration = viewModel.Duration,
            ImageUrl = viewModel.ImageUrl,
            Title = viewModel.Title,
            ReleaseDate = DateTime
                .ParseExact(viewModel.ReleaseDate,AppDateFormat,CultureInfo.InvariantCulture)

        };



        await context.AddAsync(newMovie);
        await context.SaveChangesAsync();

    }
}