using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

using MyWebApiApp.Models;
using MyWebApiApp.Services;

namespace MyWebApiApp.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController
    {
        protected IProductService ProductService { get; private set; }

        public ProductsController(IProductService productService)
        {
            this.ProductService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            return ProductService.GetProducts();
        }
    }
}
