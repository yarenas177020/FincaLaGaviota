using Lagaviota.API.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lagaviota.API.Data
{
    public class DataContext : IdentityDbContext<User> 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<AnimalType> animalTypes { get; set; }

        public DbSet<Dog> Dogs { get; set; }

        public DbSet<Operator> Operators { get; set; }

        public DbSet<Procedure> Procedures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AnimalType>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<Procedure>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<Dog>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Operator>().HasIndex(x => x.Name).IsUnique();
        }
    }
}
