using EShop.Api.Models;
using GraphQL.Types;

namespace EShop.Api.Graph.Types
{
    public sealed class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Field(t => t.Id);
            Field(t => t.Name);
        }
    }
}
