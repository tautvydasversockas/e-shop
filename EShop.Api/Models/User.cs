namespace EShop.Api.Models
{
    public sealed class User
    {
        public int Id { get; }
        public string Name { get; }

        public User(
            int id,
            string name)
        {
            Id = id;
            Name = name;
        }
    }
}
