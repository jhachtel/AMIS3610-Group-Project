using System.Linq;
using AMIS3610.GroupProject.Api.Data;
using AMIS3610.GroupProject.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AMIS3610.GroupProject.Api.Controllers
{
    [Route("api/gear")]
    [ApiController]
    public class GearController : ControllerBase
    {
        private readonly ProjectContext db;

        public GearController(ProjectContext db)
        {
            this.db = db;

            if (this.db.Gear.Count() == 0)
                {
                    this.db.Gear.Add(new Gear()
                    {
                        Id = 1,
                        Name = "Test Gear 1",
                        Brand = "This Brand",
                        Type = "Type 1",
                        Description = "The first piece of test Gear.",
                        Link = "https://www.google.com"
                    });
                    this.db.Gear.Add(new Gear()
                    {
                        Id = 2,
                        Name = "Test Gear 1",
                        Brand = "That Brand",
                        Type = "Type 2",
                        Description = "The first piece of test Gear.",
                        Link = "https://www.google.com"
                    });
                    this.db.Gear.Add(new Gear()
                    {
                        Id = 3,
                        Name = "Test Gear 1",
                        Brand = "Some Other Brand",
                        Type = "Type 3",
                        Description = "The first piece of test Gear.",
                        Link = "https://www.google.com"
                    });
                }
                this.db.SaveChanges();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Gear);
        }

        [HttpGet("{id}", Name = "GetGear")]
        public IActionResult GetGear(int id)
        {
            var Gear = db.Gear.FirstOrDefault(g => g.Id == id);

            if (Gear == null)
            {
                return NotFound();
            }

            return Ok(Gear);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Gear Gear)
        {
            if (Gear == null)
            {
                return BadRequest();
            }

            db.Gear.Add(Gear);
            db.SaveChanges();

            return CreatedAtRoute("GetGear", new { id = Gear.Id }, Gear);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Gear Gear)
        {
            if (Gear == null || Gear.Id != id)
            {
                return BadRequest();
            }

            var GearToEdit = db.Gear.FirstOrDefault(g => g.Id == id);
            if (GearToEdit == null)
            {
                return NotFound();
            }

            GearToEdit.Name = Gear.Name;
            GearToEdit.Brand = Gear.Brand;
            GearToEdit.Type = Gear.Type;
            GearToEdit.Description = Gear.Description;
            GearToEdit.Link = Gear.Link;

            db.Gear.Update(GearToEdit);
            db.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Gear = db.Gear.FirstOrDefault(g => g.Id == id);

            if (Gear == null)
            {
                return NotFound();
            }

            db.Gear.Remove(Gear);
            db.SaveChanges();

            return NoContent();
        }
    }
}
