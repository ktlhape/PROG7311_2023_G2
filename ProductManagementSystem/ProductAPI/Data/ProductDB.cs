using ProductAPI.Models;

namespace ProductAPI.Data
{
    public static class ProductDB
    {
        public static List<Product> Products { get; set; } = new List<Product>()
        { 
            new Product("P123","Butter",25.79),
            new Product("P124","Sugar",21.50),
            new Product("P125","Flour",50.89),
            new Product("P126","Salt",12.50),
            new Product("P127","Milk",18.90),
            new Product("P128","Coke",17.49),
            new Product("P129","Rice",27.49),
        };
    }
}
