using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

using MyWebApiApp.Models;
using MyWebApiApp.Services;

namespace MyWebApiApp.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            return this._productService.GetProducts();
        }
    }
}
