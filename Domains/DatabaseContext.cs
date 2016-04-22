using Microsoft.Data.Entity;

using MyWebApiApp.Models;

namespace MyWebApiApp.Domains
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=pg-host;Port=5433;Username=postgres;Password=123123;Database=oms");
        }
    }
}
