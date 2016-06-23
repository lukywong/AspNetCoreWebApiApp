using System.Collections.Generic;
using System.Linq;

using MyWebApiApp.Models;
using MyWebApiApp.Domains;

namespace MyWebApiApp.Services
{
  public class ProductService : IProductService
  {
      private readonly DatabaseContext _dbContext;

      public ProductService(DatabaseContext context)
      {
          this._dbContext = context;
      }

      public List<Product> GetProducts()
      {
          return this._dbContext.Products.Where(d => d.Id < 4).ToList();
      }
  }
}
