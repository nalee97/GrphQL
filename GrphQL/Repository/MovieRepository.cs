using GrphQL.IRepository;
using GrphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace GrphQL.Repository;

    public class MovieRepository : IMovieRepository
    {
        private readonly SuperHeroDbContext _dbContext;

        public MovieRepository(SuperHeroDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    public async Task<Movie> AddMovie(Movie movie)
    {
        await _dbContext.Movies.AddAsync(movie);
        await _dbContext.SaveChangesAsync();
        return await Task.FromResult(movie);
    }

    public async Task<Movie?> GetMovie(Guid id)
    {
        var movie = _dbContext.Movies.FirstOrDefault(x => x.Id == id);
        return await Task.FromResult(movie);
    }

    public async Task<List<Movie>> GetMovies()
    {
        var movies = await _dbContext.Movies.ToListAsync();
        return movies;
    }

    public async Task<Movie> UpdateMovie(Movie movie)
    {
        var movieToUpdate = _dbContext.Movies.FirstOrDefault(x => x.Id == movie.Id);
        if (movieToUpdate is not null)
        {
            movieToUpdate.Title = movie.Title;
            movieToUpdate.Description = movie.Description;
            movieToUpdate.Instructor = movie.Instructor;
            movieToUpdate.ReleaseDate = movie.ReleaseDate;

            // check if entity is modified
            if (_dbContext.Entry(movieToUpdate).State == EntityState.Modified)
            {
                await _dbContext.SaveChangesAsync();
            }
            return movieToUpdate;
        }

        return movie;
    }
}

