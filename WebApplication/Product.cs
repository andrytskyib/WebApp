namespace WebApplication
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }

        public Product(string name, string desc, int id)
        {
            Name = name;
            Description = desc;
            Id = id;
        }
    }
}
