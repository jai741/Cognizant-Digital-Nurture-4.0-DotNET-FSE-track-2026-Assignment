using Microsoft.EntityFrameworkCore;
using EFCore8Assignment.Models;

namespace EFCore8Assignment.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace with your SQL Server connection string
            optionsBuilder.UseSqlServer("Server=JAI;Database=EFCore8DB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
