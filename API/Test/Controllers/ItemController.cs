using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly List<Item> Items = new List<Item>
    {
        new Item { Id = 1, Name = "Item 1", Quantity = 10 },
        new Item { Id = 2, Name = "Item 2", Quantity = 5 },
        // Add more items as needed
    };

        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetItems()
        {
            return Ok(Items);
        }

    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
