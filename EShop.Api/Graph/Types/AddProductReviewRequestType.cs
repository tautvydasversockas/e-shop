using GraphQL.Types;

namespace EShop.Api.Graph.Types
{
    public sealed class AddProductReviewRequestType : InputObjectGraphType<AddProductReviewRequest>
    {
        public AddProductReviewRequestType()
        {
            Field(t => t.ProductId);
            Field(t => t.NumberOfStars);
            Field(t => t.Text);
        }
    }
}
