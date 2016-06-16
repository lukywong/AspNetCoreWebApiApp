using System.Collections.Generic;
using System.Linq;

using MyWebApiApp.Models;
using MyWebApiApp.Domains;

namespace MyWebApiApp.Services
{
  public class ProductService : IProductService
  {
      public DatabaseContext DbContext { get; set; }

      public ProductService(DatabaseContext context)
      {
          this.DbContext = context;
      }

      public List<Product> GetProducts()
      {
          return DbContext.Products.Where(d => d.Id < 4).ToList();
      }
  }
}
