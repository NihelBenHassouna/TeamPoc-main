using ApiFour.Maps;
using ApiFour.Models;
using Microsoft.EntityFrameworkCore;
namespace ApiFour.Contexts
{


    public class AggDbContext : DbContext
    {
        public AggDbContext(DbContextOptions<AggDbContext> options)
       : base(options)
        {

        }
        public DbSet<Agg> Todos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            new AggMap(modelBuilder.Entity<Agg>());

        }
    }
}