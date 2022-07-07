using FinalProject.Enums;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        //Creating test information to confirm that endpoints function 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie(1, "2", "tt0096895", "Batman89", MovieCategory.Action),
                new Movie(2, "3", "tt0145487", "Spiderman", MovieCategory.Action),
                new Movie(3, "4", "tt0322589", "Honey", MovieCategory.Drama)
                );
            modelBuilder.Entity<User>().HasData(
                new User(1, "User1", 2),
                new User(2, "User2", 3),
                new User(3, "User3", 4)
                );
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
