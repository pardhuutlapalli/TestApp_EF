using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestApp_Models.Models;

namespace TestApp_DataAccess
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS03;Database=TestDB;TrustServerCertificate=True;Trusted_Connection=True");
        }
    }
}
