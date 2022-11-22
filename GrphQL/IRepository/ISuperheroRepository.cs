using GrphQL.Models;

namespace GrphQL.IRepository;

    public interface ISuperheroRepository
    {
    Task<Superhero> AddSuperhero(Superhero superhero);

    Task<Superhero?> GetSuperhero(Guid id);

    Task<List<Superhero>> GetSuperheroes();
    Task<Superhero> UpdateSuperhero(Superhero superhero);
}

