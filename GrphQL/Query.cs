using GrphQL.Models;

namespace GrphQL;

    public class Query
    {

    private readonly SuperHeroDbContext _context;

    public Query(SuperHeroDbContext context)
    {
        _context = context;
    }

    //Fetch the list of superHeros objects

    [HotChocolate.Data.UseFiltering]
    [UseSorting]
    [GraphQLName("Superheros")]
    public IQueryable<Superhero> GetSuperheroes() =>
      _context.Superheroes;

    //Fetch the list of SuperPowers objects
    [HotChocolate.Data.UseFiltering]
    [UseSorting]
    [GraphQLName("Superpowers")]
    public IQueryable<Superpower> GetSuperpowers() =>
      _context.Superpowers;

    //Fetch the list of Movie objects
    [HotChocolate.Data.UseFiltering]
    [UseSorting]
    [GraphQLName("Movies")]
    public IQueryable<Movie> GetMovies() =>
      _context.Movies;


    [GraphQLName("GetMovieById")]
    public async Task<Movie> GetMovieById(Guid id)
    {
        return await _context.Movies.FindAsync(id);
    }


    [GraphQLName("GetSuperheroById")]
    public async Task<Superhero> GetSuperheroById(Guid id)
    {
        return await _context.Superheroes.FindAsync(id);
    }

    [GraphQLName("GetSuperpowerById")]
    public async Task<Superpower> GetSuperpowerById(Guid id)
    {
        return await _context.Superpowers.FindAsync(id);
    }

    

    //Fetch the list of superHeros by Superpower Id
    [HotChocolate.Data.UseFiltering]
    [UseSorting]
    [GraphQLName("SuperherosBySuperpowerId")]
    public IQueryable<Superhero> GetSuperheroesBySuperpowerId(Guid superpowerId) =>
      _context.Superheroes.Where(x => x.Id == superpowerId);

    //Fetch the list of superPowers by Superhero Id
    [HotChocolate.Data.UseFiltering]
    [UseSorting]
    [GraphQLName("SuperpowersByMovieId")]
    public IQueryable<Superpower> GetSuperpowersByMovieId(Guid movieId) =>
      _context.Superpowers.Where(x => x.Id == movieId);

    //Fetch the list of superPowers by Superhero Id
    [HotChocolate.Data.UseFiltering]
    [UseSorting]
    [GraphQLName("SuperpowersBySuperheroId")]
    public IQueryable<Superpower> GetSuperpowersBySuperheroId(Guid superheroId) =>
      _context.Superpowers.Where(x => x.Id == superheroId);




}

