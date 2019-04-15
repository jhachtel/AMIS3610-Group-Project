using System.Linq;
using AMIS3610.GroupProject.Api.Data;
using AMIS3610.GroupProject.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AMIS3610.GroupProject.Api.Controllers
{
    [Route("api/Person")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ProjectContext db;

        public PersonController(ProjectContext db)
        {
            this.db = db;

            if (this.db.Person.Count() == 0)
                {
                    this.db.Person.Add(new Person()
                    {
                        Id = 1,
                        Name = "Test Person 1",
                        Email = "person1@user.com",
                        Bio = "First test person."
                    });
                    this.db.Person.Add(new Person()
                    {
                        Id = 2,
                        Name = "Test Person 2",
                        Email = "person2@user.com",
                        Bio = "Second test person."
                    });
                    this.db.Person.Add(new Person()
                    {
                        Id = 3,
                        Name = "Test Person 3",
                        Email = "person3@user.com",
                        Bio = "Third test person."
                    });
                }
                this.db.SaveChanges();

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Person);
        }

        [HttpGet("{id}", Name = "GetPerson")]
        public IActionResult GetPerson(int id)
        {
            var Person = db.Person.FirstOrDefault(p => p.Id == id);

            if (Person == null)
            {
                return NotFound();
            }

            return Ok(Person);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Person Person)
        {
            if (Person == null)
            {
                return BadRequest();
            }

            db.Person.Add(Person);
            db.SaveChanges();

            return CreatedAtRoute("GetPerson", new { id = Person.Id }, Person);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Person Person)
        {
            if (Person == null || Person.Id != id)
            {
                return BadRequest();
            }

            var PersonToEdit = db.Person.FirstOrDefault(p => p.Id == id);
            if (PersonToEdit == null)
            {
                return NotFound();
            }

            PersonToEdit.Name = Person.Name;
            PersonToEdit.Email = Person.Email;
            PersonToEdit.Bio = Person.Bio;

            db.Person.Update(PersonToEdit);
            db.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Person = db.Person.FirstOrDefault(p => p.Id == id);

            if (Person == null)
            {
                return NotFound();
            }

            db.Person.Remove(Person);
            db.SaveChanges();

            return NoContent();
        }
    }
}
