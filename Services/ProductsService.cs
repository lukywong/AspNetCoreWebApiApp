using System.Collections.Generic;
using System.Linq;

using MyWebApiApp.Models;
using MyWebApiApp.Domains;

namespace MyWebApiApp.Services
{
    public class ProductsService
    {
        public List<Product> GetProducts()
        {
            using (var db = new DatabaseContext())
            {
                return db.Products.Where(d => d.Id < 4).ToList();
            }
        }
    }
}
