using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movies.Models.Entity;

namespace Movies.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext (DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Movies.Models.Entity.Movie> Movie { get; set; }

        public DbSet<Movies.Models.Entity.Cast> Cast { get; set; }

        public DbSet<Movies.Models.Entity.Actor> Actor { get; set; }
    }
}
