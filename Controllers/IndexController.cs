using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApiApp.Controllers
{
    [Route("/")]
    public class IndexController : Controller
    {
        [HttpGet]
        public object Get()
        {
            return new
            {
                Application = "AspNetCoreWebApiApp",
                Version = "0.0.1"
            };
        }
    }
}
