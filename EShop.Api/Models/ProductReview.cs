namespace EShop.Api.Models
{
    public sealed class ProductReview
    {
        public int Id { get; }
        public int ProductId { get; }
        public int UserId { get; }
        public int NumberOfStars { get; }
        public string Text { get; }

        public ProductReview(
            int id,
            int productId,
            int userId,
            int numberOfStars,
            string text)
        {
            Id = id;
            ProductId = productId;
            UserId = userId;
            NumberOfStars = numberOfStars;
            Text = text;
        }
    }
}
