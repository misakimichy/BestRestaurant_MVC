using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Pets> Pets { get; set; }

    public AnimalShelterContext(DbContextOptions options) : base(options) { }
  }
}