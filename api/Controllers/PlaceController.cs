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
                        Name = "The Flying Pig Downtown",
                        Location = "Amsterdam, NL",
                        Type = "Hostel",
                        Description = "The Flying Pig Downtown hostel is the place to party. Located in the city centre next to Amsterdam Central Station, Dam Square, The Anne Frank House and the bustling Red Light District, this 18th century building has been transformed into one of the best party spots in all of Amsterdam."
                    });
                    this.db.Place.Add(new Place()
                    {
                        Id = 2,
                        Name = "Pacific Crest Trail",
                        Location = "California, Oregon, and Washington, USA",
                        Type = "Trail",
                        Description = "The Pacific Crest Trail, officially designated as the Pacific Crest National Scenic Trail (PCT) is a long-distance hiking and equestrian trail closely aligned with the highest portion of the Sierra Nevada and Cascade mountain ranges, which lie 100 to 150 miles (160 to 240 km) east of the U.S. Pacific coast."
                    });
                    this.db.Place.Add(new Place()
                    {
                        Id = 3,
                        Name = "Schloss Herrenchiemsee",
                        Location = "Herreninsel, Bavaria, Germany",
                        Type = "Castle",
                        Description = "Herrenchiemsee is a complex of royal buildings on Herreninsel, the largest island in the Chiemsee lake, in southern Bavaria, Germany. Together with the neighbouring isle of Frauenchiemsee and the uninhabited Krautinsel, it forms the municipality of Chiemsee, located about 60 kilometres (37 mi) southeast of Munich."
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