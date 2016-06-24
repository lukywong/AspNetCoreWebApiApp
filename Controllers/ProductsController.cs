using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

using AspNetCoreWebApiApp.Models;
using AspNetCoreWebApiApp.Services;

namespace AspNetCoreWebApiApp.Controllers
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
