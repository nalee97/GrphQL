using GrphQL.Models;

namespace GrphQL;

    public class Query
    {
    [UseProjection]
    [HotChocolate.Data.UseFiltering]
    [UseSorting]
    [GraphQLName("Superheros")]
    public IQueryable<Superhero> GetSuperheroes([Service] SuperHeroDbContext context) =>
      context.Superheroes;
}

