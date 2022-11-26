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

        await context.Movies.AddAsync(movie,token);
        await context.SaveChangesAsync();
        return movie;
    }

    [GraphQLName("AddSuperhero")]
    [UseDbContext(typeof(SuperHeroDbContext))]
    public async Task<Superhero> AddSuperHeroAsync(AddSuperHeroInput input,
        [ScopedService] SuperHeroDbContext context, CancellationToken token)
    {
        var superHero = new Superhero
        {	
            Id = Guid.NewGuid(),
            Name = input.Name,
            Description = input.Description,
            Height = input.Height
        };

        await context.Superheroes.AddAsync(superHero,token);
        await context.SaveChangesAsync(token);

        return superHero;
    }

    [GraphQLName("UpdateMovie")]
    [UseDbContext(typeof (SuperHeroDbContext))]
    public async Task<Movie> UpdateMovieAsync(Movie input, [ScopedService] SuperHeroDbContext context,
        CancellationToken token)
    {
        var movie = await context.Movies.FindAsync(input.Id);

        if (movie is not null)
        {
            movie.Title = input.Title;
            movie.Description = input.Description;
            movie.ReleaseDate = input.ReleaseDate;
            movie.Instructor = input.Instructor;
        }
        else
        {
            return null;
        }

        context.Movies.Update(movie);
        await context.SaveChangesAsync(token);

        return movie;
    }
}
