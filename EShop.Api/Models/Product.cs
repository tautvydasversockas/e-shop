namespace EShop.Api.Models
{
    public sealed class Product
    {
        public int Id { get; }
        public int BrandId { get; }
        public string Name { get; }
        public decimal Price { get; }

        public Product(
            int id,
            int brandId,
            string name,
            decimal price)
        {
            Id = id;
            BrandId = brandId;
            Name = name;
            Price = price;
        }
    }
}
