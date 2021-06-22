using EShop.Api.Models;
using GraphQL.Types;

namespace EShop.Api.Graph.Types
{
    public sealed class BrandType : ObjectGraphType<Brand>
    {
        public BrandType()
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Email);
        }
    }
}
