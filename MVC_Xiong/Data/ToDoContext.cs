using Microsoft.EntityFrameworkCore;
using MVC_Xiong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Xiong.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
            : base(options) { }
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<Category1>Categories { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category1 { CategoryId = "work", Name = "Work" },
                new Category1 { CategoryId = "home", Name = "Home" },
                new Category1 { CategoryId = "ex", Name = "Exercise" },
                new Category1 { CategoryId = "shop", Name = "Shopping" },
                new Category1 { CategoryId = "call", Name = "Contact" }
                );
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "open", Name = "Open" },
                new Status { StatusId = "closed", Name = "Completed" }
                );
        }
    }
}
