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
                        Name = "REI Co-op Fleece Jacket - Men's",
                        Brand = "REI Co-op",
                        Type = "Clothing",
                        Description = "Perfect for treks outside on a cool day or layered under a coat when wet weather hits, the men's REI Co-op fleece jacket delivers all-purpose outdoor warmth."
                    });
                    this.db.Gear.Add(new Gear()
                    {
                        Id = 2,
                        Name = "Men's Moab 2 Mid Ventilator",
                        Brand = "Merrell",
                        Type = "Footwear",
                        Description = "Experience out-of-the-box comfort in this ventilated hiker. With durable synthetic leathers, a supportive footbed, and Vibram® traction, all in a versatile package, you won't doubt why Moab stands for MOTHER OF ALL BOOTS™."
                    });
                    this.db.Gear.Add(new Gear()
                    {
                        Id = 3,
                        Name = "Aspect 3 Tent",
                        Brand = "Mountain Hardwear",
                        Type = "Tent",
                        Description = "When afternoon thundershowers and swarms of skeeters threaten to mar an otherwise perfectly pleasant trip into the mountains, the Aspect™ 3 offers lightweight yet robust three-season protection. With enough living space for you and your gear, it's perfect for summer road trips, lightweight backpacking missions, and long walks to backcountry walls."
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
