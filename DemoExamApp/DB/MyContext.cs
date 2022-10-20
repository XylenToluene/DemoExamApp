using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoExamApp.DB
{
    public class MyContext : DbContext
    {
        private string cs = "Server=localhost;Database=DemoExamAppDb;Trusted_Connection=True;";

        public DbSet<User> Users { get; set; }
        public DbSet<UserStatus> UserStatus { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cs);
        }
    }
}
