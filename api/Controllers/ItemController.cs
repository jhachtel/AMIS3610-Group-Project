using System.Linq;
using AMIS3610.GroupProject.Api.Data;
using AMIS3610.GroupProject.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AMIS3610.GroupProject.Api.Controllers
{
    [Route("api/item")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ProjectContext db;

        public ItemController(ProjectContext db)
        {
            this.db = db;

            if (this.db.Item.Count() == 0)
                {
                    this.db.Item.Add(new Item()
                    {
                        Id = 1,
                        Name = "Test Item 1",
                        Brand = "This Brand",
                        Type = "Type 1",
                        Description = "The first test Item.",
                        Link = "https://www.google.com"
                    });
                    this.db.Item.Add(new Item()
                    {
                        Id = 2,
                        Name = "Test Item 2",
                        Brand = "That Brand",
                        Type = "Type 2",
                        Description = "The second test Item.",
                        Link = "https://www.google.com"
                    });
                    this.db.Item.Add(new Item()
                    {
                        Id = 3,
                        Name = "Test Item 3",
                        Brand = "Some Other Brand",
                        Type = "Type 3",
                        Description = "The third test Item.",
                        Link = "https://www.google.com"
                    });
                }
                this.db.SaveChanges();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Item);
        }

        [HttpGet("{id}", Name = "GetItem")]
        public IActionResult GetItem(int id)
        {
            var Item = db.Item.FirstOrDefault(i => i.Id == id);

            if (Item == null)
            {
                return NotFound();
            }

            return Ok(Item);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Item Item)
        {
            if (Item == null)
            {
                return BadRequest();
            }

            db.Item.Add(Item);
            db.SaveChanges();

            return CreatedAtRoute("GetItem", new { id = Item.Id }, Item);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Item Item)
        {
            if (Item == null || Item.Id != id)
            {
                return BadRequest();
            }

            var ItemToEdit = db.Item.FirstOrDefault(i => i.Id == id);
            if (ItemToEdit == null)
            {
                return NotFound();
            }

            ItemToEdit.Name = Item.Name;
            ItemToEdit.Brand = Item.Brand;
            ItemToEdit.Type = Item.Type;
            ItemToEdit.Description = Item.Description;
            ItemToEdit.Link = Item.Link;

            db.Item.Update(ItemToEdit);
            db.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Item = db.Item.FirstOrDefault(i => i.Id == id);

            if (Item == null)
            {
                return NotFound();
            }

            db.Item.Remove(Item);
            db.SaveChanges();

            return NoContent();
        }
    }
}
