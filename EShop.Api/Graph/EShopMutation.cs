using EShop.Api.DataStore;
using EShop.Api.Graph.Types;
using EShop.Api.Messaging;
using EShop.Api.Models;
using GraphQL;
using GraphQL.Types;

namespace EShop.Api.Graph
{
    public sealed class EShopMutation : ObjectGraphType
    {
        public EShopMutation(ProductReviewRepository reviewRepository, ProductReviewMessageService reviewMessageService)
        {
            Field<BooleanGraphType>()
                .Name("AddProductReview")
                .Argument<NonNullGraphType<AddProductReviewRequestType>>("Request")
                .Resolve(context =>
                {
                    var request = context.GetArgument<AddProductReviewRequest>("Request");

                    var review = new ProductReview(
                        id: reviewRepository.GetNextId(),
                        productId: request.ProductId,
                        userId: 1,
                        numberOfStars: request.NumberOfStars,
                        text: request.Text);
                    reviewRepository.Add(review);

                    var reviewAddedMessage = new ProductReviewAddedMessage(
                        Id: review.Id,
                        ProductId: review.ProductId,
                        UserId: review.UserId,
                        NumberOfStars: review.NumberOfStars,
                        Text: review.Text);
                    reviewMessageService.AddReviewAddedMessage(reviewAddedMessage);

                    return true;
                });
        }
    }
}
