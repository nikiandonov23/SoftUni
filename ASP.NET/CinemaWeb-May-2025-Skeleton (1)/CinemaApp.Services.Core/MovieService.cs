

using CinemaApp.Data;
using CinemaApp.Data.Models;
using CinemaApp.Services.Core.Interfaces;
using CinemaApp.Web.ViewModels.Movie;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
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
        return allMovies;
    }

    public async Task AddMovieAsync(MovieFormInputModel inputModel)
    {
        Movie newMovie = new Movie()
        {
            Genre = inputModel.Genre,
            Description = inputModel.Description,
            Director = inputModel.Director,
            Duration = inputModel.Duration,
            ImageUrl = inputModel.ImageUrl,
            Title = inputModel.Title,
            ReleaseDate = DateTime
                .ParseExact(inputModel.ReleaseDate,AppDateFormat,CultureInfo.InvariantCulture)

        };



        await context.AddAsync(newMovie);
        await context.SaveChangesAsync();

    }
}