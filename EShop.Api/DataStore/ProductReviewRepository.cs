using EShop.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace EShop.Api.DataStore
{
    public sealed class ProductReviewRepository
    {
        private readonly List<ProductReview> _reviews = new()
        {
            new ProductReview(
                id: 1,
                productId: 1,
                userId: 1,
                numberOfStars: 5,
                text: "The best carrots I've ever had! I feel that my eyesight is already improving!"),

            new ProductReview(
                id: 2,
                productId: 2,
                userId: 2,
                numberOfStars: 4,
                text: "The build quality is great. However, two dollars for a stick is a bit too much!")

        };

        public int GetNextId()
        {
            return _reviews.Max(review => review.Id) + 1;
        }

        public List<ProductReview> GetAllByProductId(int productId)
        {
            return _reviews.Where(review => review.ProductId == productId).ToList();
        }

        public void Add(ProductReview review)
        {
            _reviews.Add(review);
        }
    }
}
