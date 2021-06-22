using EShop.Api.Graph.Types;
using EShop.Api.Messaging;
using GraphQL.Resolvers;
using GraphQL.Types;

namespace EShop.Api.Graph
{
    public sealed class EShopSubscription : ObjectGraphType
    {
        public EShopSubscription(ProductReviewMessageService reviewMessageService)
        {
            AddField(new EventStreamFieldType
            {
                Name = "ReviewAdded",
                Type = typeof(ProductReviewAddedMessageType),
                Resolver = new FuncFieldResolver<ProductReviewAddedMessage?>(
                    context => context.Source as ProductReviewAddedMessage),
                Subscriber = new EventStreamResolver<ProductReviewAddedMessage>(
                    context => reviewMessageService.GetMessages())
            });
        }
    }
}
