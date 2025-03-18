using SP2025_Assignment3_2._0_MMcConnell.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SP2025_Assignment3_2._0_MMcConnell.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; } // If you have a many-to-many relationship
    }
}
