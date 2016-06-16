using Microsoft.EntityFrameworkCore;

using MyWebApiApp.Models;

namespace MyWebApiApp.Domains
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() {}
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
          : base(options)
        { }
        public DbSet<Product> Products { get; set; }
    }
}
