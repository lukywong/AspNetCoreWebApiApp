using System.Collections.Generic;

using AspNetCoreWebApiApp.Models;

namespace AspNetCoreWebApiApp.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
