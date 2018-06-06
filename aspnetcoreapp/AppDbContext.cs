using Microsoft.EntityFrameworkCore;
using aspnetcoreapp.Entity;
namespace aspnetcoreapp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
           : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}