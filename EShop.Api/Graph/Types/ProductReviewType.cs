using EShop.Api.DataStore;
using EShop.Api.Models;
using GraphQL.Types;

namespace EShop.Api.Graph.Types
{
    public sealed class ProductReviewType : ObjectGraphType<ProductReview>
    {
        public ProductReviewType(UserRepository userRepository)
        {
            Field(t => t.Id);
            Field(t => t.NumberOfStars);
            Field(t => t.Text);

            Field<UserType>()
                .Name("User")
                .Resolve(context => userRepository.GetById(context.Source.UserId));
        }
    }
}
