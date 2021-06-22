using EShop.Api.DataStore;
using EShop.Api.Messaging;
using GraphQL.Types;

namespace EShop.Api.Graph.Types
{
    public sealed class ProductReviewAddedMessageType : ObjectGraphType<ProductReviewAddedMessage>
    {
        public ProductReviewAddedMessageType(UserRepository userRepository)
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
