using Microsoft.AspNetCore.Mvc;


namespace WebApplication.Controllers
{
    public class ProductController : BaseController
    {
        private static readonly List<Product> Products = new List<Product>()
        {
            new Product { Name = "Produc 1", Description = "Bla Bla", Id = 1 },
            new Product { Name = "Produc 2", Description = "Bla Bla", Id = 2 },
            new Product { Name = "Produc 3", Description = "Bla Bla", Id = 3 },

        };

        [HttpGet]
        public List<Product> Get()
        {
            return Products;
        }

        [HttpGet("{id}")]
        public Product GetById(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }

        [HttpPost]
        public List<Product> Create(Product product) 
        {
            Products.Add(product);
            return Products;
        }

        [HttpPut("{id}")]
        public Product Update(int id, Product product) 
        {
             var prod = Products.FirstOrDefault(p=>p.Id == id);
             prod.Name = product.Name;
             prod.Description = product.Description;
             return prod;
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var item = Products.FirstOrDefault(p => p.Id == id);
            if(item== null) 
            { 
                return false; 
            }
            Products.Remove(item);
            return true;
        }

    }
}
