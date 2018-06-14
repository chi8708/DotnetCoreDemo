using Microsoft.EntityFrameworkCore;
using webapi.Model;
namespace webapi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
           : base(options)
        {
        }

        public DbSet<TodoItem> TodoItem { get; set; }
    }
}