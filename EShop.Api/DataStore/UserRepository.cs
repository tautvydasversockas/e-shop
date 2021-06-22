using EShop.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace EShop.Api.DataStore
{
    public sealed class UserRepository
    {
        private readonly List<User> _users = new()
        {
            new User(
                id: 1,
                name: "John Madison"),

            new User(
                id: 2,
                name: "Tim Norton")
        };

        public User? GetById(int id)
        {
            return _users.SingleOrDefault(user => user.Id == id);
        }
    }
}
