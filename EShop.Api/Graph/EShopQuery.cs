using EShop.Api.DataStore;
using EShop.Api.Graph.Types;
using GraphQL;
using GraphQL.Types;

namespace EShop.Api.Graph
{
    public sealed class EShopQuery : ObjectGraphType
    {
        public EShopQuery(ProductRepository productRepository)
        {
            Field<NonNullGraphType<ListGraphType<ProductType>>>()
                .Name("Products")
                .Resolve(context => productRepository.GetAll());

            Field<ProductType>()
                .Name("Product")
                .Argument<NonNullGraphType<IntGraphType>>("Id")
                .Resolve(context =>
                {
                    var id = context.GetArgument<int>("Id");
                    return productRepository.GetById(id);
                });
        }
    }
}
