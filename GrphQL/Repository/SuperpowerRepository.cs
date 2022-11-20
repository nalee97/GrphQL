using GrphQL.IRepository;
using GrphQL.Models;

namespace GrphQL.Repository;

    public class SuperpowerRepository : ISuperpowerRepository
    {
    private readonly SuperHeroDbContext _dbContext;


    public SuperpowerRepository(SuperHeroDbContext dbContext)
    {
        _dbContext = dbContext;
    }
}

