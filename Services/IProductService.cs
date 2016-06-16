using System.Collections.Generic;

using MyWebApiApp.Models;

namespace MyWebApiApp.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
