using GrphQL.Models;

namespace GrphQL;

public class Mutation
{
    [GraphQLName("AddMovie")]
    [UseDbContext(typeof(SuperHeroDbContext))]
    public async Task<Movie> AddMovieAsync(AddMovieInput input, [ScopedService] SuperHeroDbContext context,
        CancellationToken token)
    {
        var movie = new Movie
        {
            Id = Guid.NewGuid(),
            Title = input.Title,
            Description = input.Description,
            ReleaseDate = input.ReleaseDate,
            Instructor = input.Instructor
        };
        await context.Movies.AddAsync(movie, token);
        await context.SaveChangesAsync(token);
        return movie;
    }

}
