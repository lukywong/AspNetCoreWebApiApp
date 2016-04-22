using System.Collections.Generic;

using Microsoft.AspNet.Mvc;

using MyWebApiApp.Models;
using MyWebApiApp.Services;

namespace MyWebApiApp.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public IList<Product> Get()
        {
            var service = new ProductsService();
            return service.GetProducts();
        }
    }
}
