using System.Linq;
using AMIS3610.GroupProject.Api.Data;
using AMIS3610.GroupProject.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AMIS3610.GroupProject.Api.Controllers
{
    [Route("api/trail")]
    [ApiController]
    public class TrailController : ControllerBase
    {
        private readonly ProjectContext db;

        public TrailController(ProjectContext db)
        {
            this.db = db;

            if (this.db.Trail.Count() == 0)
                {
                    this.db.Trail.Add(new Trail()
                    {
                        Id = 1,
                        Name = "Test Trail 1",
                        //Place = null,
                        Description = "The first test Trail.",
                        Link = "https://www.google.com"
                    });
                    this.db.Trail.Add(new Trail()
                    {
                        Id = 2,
                        Name = "Test Trail 2",
                        //Place = null,
                        Description = "The second test Trail.",
                        Link = "https://www.google.com"
                    });
                    this.db.Trail.Add(new Trail()
                    {
                        Id = 3,
                        Name = "Test Trail 3",
                        //Place = null,
                        Description = "The third test Trail.",
                        Link = "https://www.google.com"
                    });
                }
                this.db.SaveChanges();

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Trail);
        }

        [HttpGet("{id}", Name = "GetTrail")]
        public IActionResult GetTrail(int id)
        {
            var Trail = db.Trail.FirstOrDefault(t => t.Id == id);

            if (Trail == null)
            {
                return NotFound();
            }

            return Ok(Trail);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Trail Trail)
        {
            if (Trail == null)
            {
                return BadRequest();
            }

            db.Trail.Add(Trail);
            db.SaveChanges();

            return CreatedAtRoute("GetTrail", new { id = Trail.Id }, Trail);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Trail Trail)
        {
            if (Trail == null || Trail.Id != id)
            {
                return BadRequest();
            }

            var TrailToEdit = db.Trail.FirstOrDefault(t => t.Id == id);
            if (TrailToEdit == null)
            {
                return NotFound();
            }

            TrailToEdit.Name = Trail.Name;
            //TrailToEdit.Place = Trail.Place;
            TrailToEdit.Description = Trail.Description;
            TrailToEdit.Link = Trail.Link;

            db.Trail.Update(TrailToEdit);
            db.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Trail = db.Trail.FirstOrDefault(p => p.Id == id);

            if (Trail == null)
            {
                return NotFound();
            }

            db.Trail.Remove(Trail);
            db.SaveChanges();

            return NoContent();
        }
    }
}