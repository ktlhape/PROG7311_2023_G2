using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Data;
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("All")]
        public ActionResult<List<Product>> GetProducts()
        {
            return ProductDB.Products;
        }

        [HttpGet]
        [Route("{price}", Name = "ByPrice")]
        public List<Product> GetProductsByPrice(double price)
        {
            return ProductDB.Products.Where(p => p.Price < price).ToList();
        }
        [HttpGet]
        [Route("prd/{code}")]
        public Product GetProduct(string code)
        {
            return ProductDB.Products.Where(p => p.Code.Equals(code)).FirstOrDefault();
        }

        [HttpPost]
        [Route("Create")]
        public bool CreateProduct(string code, string desc, double price)
        {
            Product pr = new Product(code, desc, price);
            ProductDB.Products.Add(pr);
            return true;
        }

        [HttpDelete]
        [Route("Delete/{code}")]
        public bool DeleteProduct(string code)
        {
            var pr = ProductDB.Products.Where(p => p.Code.Equals(code)).FirstOrDefault();

            return ProductDB.Products.Remove(pr);
        }

        [HttpPut]
        [Route("Update/{code}")]
        public bool UpdateProduct(string code, string desc, double price)
        {
            var pr = ProductDB.Products.Where(p => p.Code.Equals(code)).FirstOrDefault();
            if (pr != null)
            {
                pr.Desc = desc;
                pr.Price = price;
                return true;
            }
            return false;
        }


    }
}
