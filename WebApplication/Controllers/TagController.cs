using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class TagController : BaseController
    {
        private static readonly List<Tag> Tags = new List<Tag>()
        {
            new Tag{Name= "Product 1", Description = "This veg", Id = 1, ProductId = 1},
            new Tag{Name= "Product 2", Description = "This fruit", Id = 2, ProductId = 2},
            new Tag{Name= "Product 3", Description = "This veg", Id = 3, ProductId = 1},
            new Tag{Name= "Product 4", Description = "This fruit", Id = 4, ProductId = 2}
        };

        [HttpGet]
        public List<Tag> GetTags()
        {
            return Tags;
        }

        [HttpGet("{id}")]
        public ActionResult<Tag> GetById(int id)
        {
            var tag = Tags.FirstOrDefault(p => p.Id == id);
            if (tag == null)
            {
                return NotFound();
            }
            return tag;
        }

        [HttpPost]
        public List<Tag> Create(Tag tag)
        {
            Tags.Add(tag);
            return Tags;
        }

        [HttpPut("{id}")]
        public Tag Update(int id, Tag tag)
        {
            var res = Tags.FirstOrDefault(p => p.Id == id);
            res.Name = tag.Name;
            res.Description = tag.Description;
            return res;
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var tag = Tags.FirstOrDefault(p => p.Id == id);
            if (tag == null) 
            {
                return false;
            }
            Tags.Remove(tag);
            return true;
        }
    }
} 
