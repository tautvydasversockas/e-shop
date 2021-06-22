using EShop.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace EShop.Api.DataStore
{
    public sealed class BrandRepository
    {
        private readonly List<Brand> _brands = new()
        {
            new Brand(
                id: 1,
                name: "Carrots & Sticks",
                email: "info@carrotsandsticks.com")
        };

        public Brand? GetById(int id)
        {
            return _brands.SingleOrDefault(brand => brand.Id == id);
        }
    }
}
