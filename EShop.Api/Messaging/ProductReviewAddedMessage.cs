namespace EShop.Api.Messaging
{
    public sealed record ProductReviewAddedMessage(
        int Id,
        int ProductId,
        int UserId,
        int NumberOfStars,
        string Text);
}
