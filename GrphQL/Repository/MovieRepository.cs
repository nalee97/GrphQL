using GrphQL.IRepository;
using GrphQL.Models;

namespace GrphQL.Repository;

    public class MovieRepository : IMovieRepository
    {
        private readonly SuperHeroDbContext _dbContext;

        public MovieRepository(SuperHeroDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }

