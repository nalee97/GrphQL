using GrphQL.Models;

namespace GrphQL.IRepository;

    public interface IMovieRepository
    {
    Task<Movie> AddMovie(Movie movie);

    Task<Movie?> GetMovie(Guid id);

    Task<List<Movie>> GetMovies();
    Task<Movie> UpdateMovie(Movie movie);
}

