using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;
using ProductAPI.Data;
using Newtonsoft.Json;

namespace SupplierProductApplication.Controllers
{
    public class ProductController : Controller
    {
        Uri baseAddress = new Uri("http://localhost:5171/api/");
        HttpClient _client;
        public ProductController()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseAddress;
        }
        public IActionResult Index()
        {
            List<Product> prList = new List<Product>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "Product/GetProducts/All").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                prList = JsonConvert.DeserializeObject<List<Product>>(data);

            }
            return View(prList);
        }
    }
}
