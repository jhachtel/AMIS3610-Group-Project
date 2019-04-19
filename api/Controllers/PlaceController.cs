using System.Linq;
using AMIS3610.GroupProject.Api.Data;
using AMIS3610.GroupProject.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AMIS3610.GroupProject.Api.Controllers
{
    [Route("api/place")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        private readonly ProjectContext db;

        public PlaceController(ProjectContext db)
        {
            this.db = db;

            if (this.db.Place.Count() == 0)
                {
                    this.db.Place.Add(new Place()
                    {
                        Id = 1,
                        Name = "Test Place 1",
                        Location = "Here",
                        Type = "Type 1",
                        Description = "The first test Place.",
                        Link = "https://www.google.com"
                    });
                    this.db.Place.Add(new Place()
                    {
                        Id = 2,
                        Name = "Test Place 2",
                        Location = "There",
                        Type = "Type 2",
                        Description = "The second test Place.",
                        Link = "https://www.google.com"
                    });
                    this.db.Place.Add(new Place()
                    {
                        Id = 3,
                        Name = "Test Place 3",
                        Location = "Everywhere",
                        Type = "Type 3",
                        Description = "The third test Place.",
                        Link = "https://www.google.com"
                    });
                }
                this.db.SaveChanges();

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Place);
        }

        [HttpGet("{id}", Name = "GetPlace")]
        public IActionResult GetPlace(int id)
        {
            var Place = db.Place.FirstOrDefault(p => p.Id == id);

            if (Place == null)
            {
                return NotFound();
            }

            return Ok(Place);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Place Place)
        {
            if (Place == null)
            {
                return BadRequest();
            }

            db.Place.Add(Place);
            db.SaveChanges();

            return CreatedAtRoute("GetPlace", new { id = Place.Id }, Place);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Place Place)
        {
            if (Place == null || Place.Id != id)
            {
                return BadRequest();
            }

            var PlaceToEdit = db.Place.FirstOrDefault(p => p.Id == id);
            if (PlaceToEdit == null)
            {
                return NotFound();
            }

            PlaceToEdit.Name = Place.Name;
            PlaceToEdit.Location = Place.Location;
            PlaceToEdit.Type = Place.Type;
            PlaceToEdit.Description = Place.Description;

            db.Place.Update(PlaceToEdit);
            db.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Place = db.Place.FirstOrDefault(p => p.Id == id);

            if (Place == null)
            {
                return NotFound();
            }

            db.Place.Remove(Place);
            db.SaveChanges();

            return NoContent();
        }
    }
}