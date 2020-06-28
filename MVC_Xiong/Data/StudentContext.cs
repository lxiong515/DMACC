using Microsoft.EntityFrameworkCore;
using MVC_Xiong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MVC_Xiong.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
             : base(options)
        {
        }
       
        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:lxiong.database.windows.net,1433;Initial Catalog=Student;Persist Security Info=False;User ID=lxiong;Password=Summer50317;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        // public DbSet<Contacts> Contacts { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    ID = 1,
                    FirstName = "John",
                    LastName = "Smith",
                    Grade = "A"
                },
                new Student
                {
                    ID = 2,
                    FirstName = "John",
                    LastName = "Smith",
                    Grade = "A"
                },
                new Student
                {
                    ID = 3,
                    FirstName = "John",
                    LastName = "Smith",
                    Grade = "A"
                }) ;
                 
            

        }
    
    }
}
