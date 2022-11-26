using GrphQL.Models;

namespace GrphQL.IRepository;

    public interface ISuperpowerRepository
    {
    Task<Superpower> AddSuperpower(Superpower superpower);

    Task<Superpower?> GetSuperpower(Guid id);

    Task<List<Superpower>> GetSuperpowers();
    Task<Superpower> UpdateSuperpower(Superpower superpower);
}

