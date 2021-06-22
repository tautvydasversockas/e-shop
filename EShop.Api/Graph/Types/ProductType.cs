using EShop.Api.DataStore;
using EShop.Api.Models;
using GraphQL.Types;

namespace EShop.Api.Graph.Types
{
    public sealed class ProductType : ObjectGraphType<Product>
    {
        public ProductType(ProductReviewRepository reviewRepository, BrandRepository brandRepository)
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Price);

            Field<BrandType>()
                .Name("Brand")
                .Resolve(context => brandRepository.GetById(context.Source.BrandId));

            Field<NonNullGraphType<ListGraphType<ProductReviewType>>>()
                .Name("Reviews")
                .Resolve(context => reviewRepository.GetAllByProductId(context.Source.Id));
        }
    }
}
