namespace APIDemo.Models
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public Product(int code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
