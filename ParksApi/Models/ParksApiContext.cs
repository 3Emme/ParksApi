using Microsoft.EntityFrameworkCore;

namespace ParksApi.Models
{
  public class ParksApiContext : DbContext
  {
    public virtual DbSet<NationalPark> NationalParks { get; set; }
    public virtual DbSet<StatePark> StateParks { get; set; }
    public virtual DbSet<State> States { get; set; }
    public DbSet<StateJoin> StateJoins { get; set; }

    public ParksApiContext(DbContextOptions options) : base(options) { }

  }

}