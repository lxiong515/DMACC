using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Xiong.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;

namespace MVC_Xiong.Data
{
    public class ContactsContext : DbContext
    {
        
        public ContactsContext (DbContextOptions<ContactsContext> options)
            : base(options)
        {
        }
        public DbSet<Contacts> Contact { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:cis174summer.database.windows.net,1433;Initial Catalog=WebApplication1_db;Persist Security Info=False;User ID=lxiong;Password=Summer50317;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
