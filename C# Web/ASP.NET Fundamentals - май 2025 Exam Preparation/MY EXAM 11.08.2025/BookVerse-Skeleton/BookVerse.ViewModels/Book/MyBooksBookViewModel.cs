﻿namespace BookVerse.ViewModels.Book;

public class MyBooksBookViewModel
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Genre { get; set; } = null!;

    public string? CoverImageUrl { get; set; }
}