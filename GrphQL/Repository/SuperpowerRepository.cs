using GrphQL.IRepository;
using GrphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace GrphQL.Repository;

    public class SuperpowerRepository : ISuperpowerRepository
    {
    private readonly SuperHeroDbContext _dbContext;


    public SuperpowerRepository(SuperHeroDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Superpower> AddSuperpower(Superpower superpower)
    {
        await _dbContext.Superpowers.AddAsync(superpower);
        await _dbContext.SaveChangesAsync();
        return await Task.FromResult(superpower);
    }

    public async Task<Superpower?> GetSuperpower(Guid id)
    {
        var superpower = _dbContext.Superpowers.FirstOrDefault(x => x.Id == id);
        return await Task.FromResult(superpower);
    }

    public async Task<List<Superpower>> GetSuperpowers()
    {
        var superpowers = await _dbContext.Superpowers.ToListAsync();
        return superpowers;
    }

    public async Task<Superpower> UpdateSuperpower(Superpower superpower)
    {
        var superpowerToUpdate = _dbContext.Superpowers.FirstOrDefault(x => x.Id == superpower.Id);
        if (superpowerToUpdate is not null)
        {
            superpowerToUpdate.SuperPower = superpower.SuperPower;
            superpowerToUpdate.Description = superpower.Description;
            

            // check if entity is modified
            if (_dbContext.Entry(superpowerToUpdate).State == EntityState.Modified)
            {
                await _dbContext.SaveChangesAsync();
            }
            return superpowerToUpdate;
        }

        return superpower;
    }


}

