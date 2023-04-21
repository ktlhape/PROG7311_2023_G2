using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIDemo.Models;

namespace APIDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        //[Route("Product")]
        public string GetProduct()
        {
            return "Milk";
        }
        [HttpGet]
        [Route("All", Name = "AllProducts")] 
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return new List<Product> {
            new Product(1,"Coke"),
            new Product(2,"Butter"),
            new Product(4,"Sugar"),
            new Product(6,"Sprite"),
            new Product(8,"Maize"),
            };
        }


    }
}
