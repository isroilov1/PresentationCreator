using Domain.Models;

namespace Data.Interfaces;

public interface IPresentationInterface
{
    Task CreateAsync(Presentation presentation);
    Task UpdateAsync(Presentation presentation);
    Task DeleteAsync(Presentation presentation);
    Task<Presentation?> GetByIdAsync(int id);
    Task<List<Presentation>> GetAllAsync();
}
