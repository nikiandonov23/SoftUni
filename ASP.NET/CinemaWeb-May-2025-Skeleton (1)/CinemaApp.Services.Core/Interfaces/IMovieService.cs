﻿using CinemaApp.Web.ViewModels.Movie;

namespace CinemaApp.Services.Core.Interfaces;

public interface IMovieService
{
    Task<IEnumerable<AllMoviesIndexViewModel>> GetAllMoviesAsync();
    Task AddAsync(MovieFormViewModel viewModel);

}