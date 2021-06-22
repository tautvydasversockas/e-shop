namespace EShop.Api.Models
{
    public sealed class Brand
    {
        public int Id { get; }
        public string Name { get; }
        public string Email { get; }

        public Brand(
            int id,
            string name,
            string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
