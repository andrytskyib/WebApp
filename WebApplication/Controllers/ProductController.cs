using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class ProductController : BaseController
    {
        private static readonly List<Product> Prodcuts = new List<Product>()
        {
            new Product("Produc 1", "Bla Bla", 1),
            new Product("Produc 2", "Bla Bla", 2),
            new Product("Produc 3", "Bla Bla", 3)

        };

        [HttpGet]
        public List<Product> Get()
        {
            return Prodcuts;
        }
    }
}
