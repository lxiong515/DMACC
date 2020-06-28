using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Xiong.Models;
using MVC_Xiong.Controllers;

namespace MVC_Xiong.Data 
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }

        // public DbSet<Contacts> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 6,
                    Title = "Casablanca",
                    ReleaseDate = new DateTime(1942, 08, 07),
                    Genre = "Classic",
                    Price = 5
                },
                new Movie
                {
                    Id = 7,
                    Title = "Wonder Woman",
                    ReleaseDate = new DateTime(2017, 07, 16),
                    Genre = "Action",
                    Price = 9
                },
                new Movie
                {
                    Id = 8,
                    Title = "John Wick",
                    ReleaseDate = new DateTime(2019, 08, 07),
                    Genre = "Action",
                    Price = 12
                }
                 );
                
        }
    }
}
