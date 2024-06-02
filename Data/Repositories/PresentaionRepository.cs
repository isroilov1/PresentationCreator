using Data.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class PresentaionRepository(AppDbContext dbContext) : IPresentationInterface
{
    private readonly AppDbContext _dbContext = dbContext;

    public async Task CreateAsync(Presentation presentation)
    {
        await _dbContext.Presentation.AddAsync(presentation);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Presentation presentation)
    {
        _dbContext.Presentation.Remove(presentation);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Presentation>> GetAllAsync()
        => await _dbContext.Presentation.ToListAsync();

    public async Task<Presentation?> GetByIdAsync(int id)
        => await _dbContext.Presentation.FirstOrDefaultAsync(x => x.Id == id);

    public async Task UpdateAsync(Presentation presentation)
    {
        _dbContext.Presentation.Update(presentation);
        await _dbContext.SaveChangesAsync();
    }
}
