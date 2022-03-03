using ApiTwo.Maps;
using ApiTwo.Models;
using Microsoft.EntityFrameworkCore;
namespace ApiTwo.Contexts
{


    public class InputDbContext : DbContext
    {
        public InputDbContext(DbContextOptions<InputDbContext> options)
       : base(options)
        {

        }
        public DbSet<Link> Todos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            new InputPowerMap(modelBuilder.Entity<Link>());

        }
    }
}