namespace Supermarket.API.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string name { get; set; }

        public IList<Product> Products  { get; set; } = new List<Product>();

    }
}