using Microsoft.EntityFrameworkCore;

using AspNetCoreWebApiApp.Models;

namespace AspNetCoreWebApiApp.Domains
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
          : base(options)
        { }
        public DbSet<Product> Products { get; set; }
    }
}
