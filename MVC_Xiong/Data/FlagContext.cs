using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Xiong.Models;

namespace MVC_Xiong.Data
{
    public class FlagContext : DbContext
    {
        public FlagContext(DbContextOptions<FlagContext> options)
            : base(options) { }

        public DbSet<Flag> Country { get; set; }
        public DbSet<Olympic> Game { get; set; }
        public DbSet<Category> Sport { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Flag>().HasData(
                new Flag { Country = "something" }
                );
            modelBuilder.Entity<Olympic>().HasData(
                new Olympic { Game = "something" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { Sport = "something" }
                );
        }
    }
}
