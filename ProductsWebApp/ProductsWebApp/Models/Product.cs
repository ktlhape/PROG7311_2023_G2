namespace ProductsWebApp.Models
{
    public class Product
    {
        public string? Code { get; set; }
        public string? Desc { get; set; }
        public double Price { get; set; }
        public Supplier? Supplier { get; set; }

        public Product(string? code, string? desc, double price)
        {
            Code = code;
            Desc = desc;
            Price = price;
        }
    }
}
