using GraphQL.Types;
using System;

namespace EShop.Api.Graph
{
    public sealed class EShopSchema : Schema
    {
        public EShopSchema(
            IServiceProvider services,
            EShopQuery query,
            EShopMutation mutation,
            EShopSubscription subscription)
            : base(services)
        {
            Query = query;
            Mutation = mutation;
            Subscription = subscription;
        }
    }
}
