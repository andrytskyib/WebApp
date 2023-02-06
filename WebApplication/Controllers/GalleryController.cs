using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace WebApplication.Controllers
{
    public class GalleryController : BaseController
    {
        private static readonly List<Card> Cards = new List<Card>()
        {
            new Card() { Url = "desktopwallpapers.org.ua/mini/201507/40069.jpg", Name = "CHEVROLET", Id = 1, Description = "Be conveyed to users of assistive technologies – such as", Date = 1422153200637},
            new Card() { Url = "desktopwallpapers.org.ua/mini/201507/40068.jpg", Name = "DEWOO", Id = 2, Description = "sing color to add meaning to a button", Date = 1421153200637},
            new Card() { Url = "desktopwallpapers.org.ua/mini/201507/40067.jpg", Name = "FOLKSWAGEN", Id = 3, Description = "be conveyed to users of assistive technologies", Date = 1426153200637},
            new Card() { Url = "desktopwallpapers.org.ua/mini/201507/40057.jpg", Name = "FERRARI", Id = 4, Description = "ssistive technologies – such as screen readers. Ensure", Date = 1428153200637},
            new Card() { Url = "desktopwallpapers.org.ua/mini/201507/40066.jpg", Name = "BMW", Id = 5, Description = "color to add meaning to a button only provides", Date = 1402153200637},
            new Card() { Url = "desktopwallpapers.org.ua/mini/201507/40064.jpg", Name = "MERCEDESS", Id = 6, Description = "om the content itself (the visible text of the button)", Date = 1442153200637},
            new Card() { Url = "desktopwallpapers.org.ua/mini/201507/40063.jpg", Name = "SKODA", Id = 7, Description = "r is either obvious from the content itself", Date = 1482153200637},
            new Card() { Url = "desktopwallpapers.org.ua/mini/201507/40062.jpg", Name = "FORD", Id = 8, Description = "included through alternative means, such as additional text hidden with the", Date = 1442153200637},
            new Card() { Url = "desktopwallpapers.org.ua/mini/201507/40059.jpg", Name = "TOYOTA", Id = 9, Description = "meaning to a button only provides a visual", Date = 1322153200637},
            new Card() { Url = "desktopwallpapers.org.ua/mini/201507/40058.jpg", Name = "RENAULT", Id = 10, Description = "uded through alternative means, such as additional", Date = 1322159200637},

        };

        [HttpGet]
        public List<Card> Get()
        {
            return Cards;
        }

        [HttpGet("{id}")]
        public ActionResult<Card> GetById(int id) 
        {
            var card = Cards.FirstOrDefault(x => x.Id == id);
            if (card == null)
            {
                return NotFound();
            }
            return card;
        }

        [HttpPost]
        public List<Card> Create(Card card)
        {
            Cards.Add(card);
            return Cards;
        }

        [HttpPut("{id}")]
        public Card Update (int id, Card card)
        {
            var car = Cards.FirstOrDefault(p => p.Id == id);
            car.Url = card.Url;
            car.Name = card.Name;
            car.Description = card.Description;
            car.Date = card.Date;
            return car;
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var car = Cards.FirstOrDefault(x =>x.Id == id);
            if (car == null)
            {
                return false;
            }
            Cards.Remove(car);
            return true;
        }
    }
}
