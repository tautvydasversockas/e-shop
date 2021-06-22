using EShop.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace EShop.Api.DataStore
{
    public sealed class ProductRepository
    {
        private readonly List<Product> _products = new()
        {
            new Product(
                id: 1,
                brandId: 1,
                name: "Carrot",
                price: 0.67m),

            new Product(
                id: 2,
                brandId: 1,
                name: "Stick",
                price: 1.97m),
        };

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product? GetById(int id)
        {
            return _products.SingleOrDefault(product => product.Id == id);
        }
    }
}
