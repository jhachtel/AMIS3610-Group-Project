using System.Linq;
using AMIS3610.GroupProject.Api.Data;
using AMIS3610.GroupProject.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AMIS3610.GroupProject.Api.Controllers
{
    [Route("api/People")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly ProjectContext db;

        public PeopleController(ProjectContext db)
        {
            this.db = db;

            if (this.db.People.Count() == 0)
                {
                    this.db.People.Add(new People()
                    {
                        Id = 1,
                        Name = "REI Co-op Fleece Jacket - Men's",
                        Contactinfo = "REI Co-op",
                        Bio = "Perfect for treks outside on a cool day or layered under a coat when wet weather hits, the men's REI Co-op fleece jacket delivers all-purpose outdoor warmth."
                    });
                    this.db.People.Add(new People()
                    {
                        Id = 2,
                        Name = "Men's Moab 2 Mid Ventilator",
                        Contactinfo = "Merrell",
                        Bio = "Experience out-of-the-box comfort in this ventilated hiker. With durable synthetic leathers, a supportive footbed, and Vibram® traction, all in a versatile package, you won't doubt why Moab stands for MOTHER OF ALL BOOTS™."
                    });
                    this.db.People.Add(new People()
                    {
                        Id = 3,
                        Name = "Aspect 3 Tent",
                        Contactinfo = "Mountain Hardwear",
                        Bio = "When afternoon thundershowers and swarms of skeeters threaten to mar an otherwise perfectly pleasant trip into the mountains, the Aspect™ 3 offers lightweight yet robust three-season protection. With enough living space for you and your People, it's perfect for summer road trips, lightweight backpacking missions, and long walks to backcountry walls."
                    });
                }
                this.db.SaveChanges();

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.People);
        }

        [HttpGet("{id}", Name = "GetPeople")]
        public IActionResult GetPeople(int id)
        {
            var People = db.People.FirstOrDefault(g => g.Id == id);

            if (People == null)
            {
                return NotFound();
            }

            return Ok(People);
        }

        [HttpPost]
        public IActionResult Post([FromBody]People People)
        {
            if (People == null)
            {
                return BadRequest();
            }

            db.People.Add(People);
            db.SaveChanges();

            return CreatedAtRoute("GetPeople", new { id = People.Id }, People);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]People People)
        {
            if (People == null || People.Id != id)
            {
                return BadRequest();
            }

            var PeopleToEdit = db.People.FirstOrDefault(g => g.Id == id);
            if (PeopleToEdit == null)
            {
                return NotFound();
            }

            PeopleToEdit.Name = People.Name;
            PeopleToEdit.Contactinfo = People.Contactinfo;
            PeopleToEdit.Bio = People.Bio;

            db.People.Update(PeopleToEdit);
            db.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var People = db.People.FirstOrDefault(g => g.Id == id);

            if (People == null)
            {
                return NotFound();
            }

            db.People.Remove(People);
            db.SaveChanges();

            return NoContent();
        }
    }
}
