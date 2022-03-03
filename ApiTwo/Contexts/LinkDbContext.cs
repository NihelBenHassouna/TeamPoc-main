using ApiTwo.Maps;
using ApiTwo.Models;
using Microsoft.EntityFrameworkCore;
namespace ApiTwo.Contexts
{


    public class LinkDbContext : DbContext
    {
        public LinkDbContext(DbContextOptions<LinkDbContext> options)
       : base(options)
        {

        }
        public DbSet<Input> Todos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            new LinkMap(modelBuilder.Entity<Input>());

        }
    }
}