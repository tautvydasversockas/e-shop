namespace EShop.Api.Graph.Types
{
    public sealed record AddProductReviewRequest(
        int ProductId,
        int NumberOfStars,
        string Text);
}
