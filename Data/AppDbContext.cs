using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data;
public class AppDbContext(DbContextOptions<AppDbContext> options)
    : DbContext(options)
{
    public DbSet<Presentation> Presentation { get; set; }
}
