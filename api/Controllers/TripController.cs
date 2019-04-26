using System.Linq;
using AMIS3610.GroupProject.Api.Data;
using AMIS3610.GroupProject.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AMIS3610.GroupProject.Api.Controllers
{
    [Route("api/trip")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private readonly ProjectContext db;

        public TripController(ProjectContext db)
        {
            this.db = db;

            if (this.db.Trip.Count() == 0)
                {
                    this.db.Trip.Add(new Trip()
                    {
                        Id = 1,
                        Name="Trip 1",
                        Description = "Super cool Trip 1.",
                        Companions = null,
                        ItemList = null,
                        Places = null,
                        Trails = null
                    });
                    this.db.Trip.Add(new Trip()
                    {
                        Id = 2,
                        Name="Trip 2",
                        Description = "Super cool Trip 2.",
                        Companions = null,
                        ItemList = null,
                        Places = null,
                        Trails = null
                    });
                    this.db.Trip.Add(new Trip()
                    {
                        Id = 3,
                        Name="Trip 3",
                        Description = "Super cool Trip 3.",
                        Companions = null,
                        ItemList = null,
                        Places = null,
                        Trails = null
                    });
                }
                this.db.SaveChanges();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Trip);
        }

        [HttpGet("{id}", Name = "GetTrip")]
        public IActionResult GetTrip(int id)
        {
            var Trip = db.Trip.FirstOrDefault(t => t.Id == id);

            if (Trip == null)
            {
                return NotFound();
            }

            return Ok(Trip);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Trip Trip)
        {
            if (Trip == null)
            {
                return BadRequest();
            }

            db.Trip.Add(Trip);
            db.SaveChanges();

            return CreatedAtRoute("GetTrip", new { id = Trip.Id }, Trip);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Trip Trip)
        {
            if (Trip == null || Trip.Id != id)
            {
                return BadRequest();
            }

            var TripToEdit = db.Trip.FirstOrDefault(t => t.Id == id);
            if (TripToEdit == null)
            {
                return NotFound();
            }

            TripToEdit.Name = Trip.Name;
            TripToEdit.Description = Trip.Description;
            // TripToEdit.Companions = Trip.Companions;
            // TripToEdit.GearList = Trip.GearList;
            // TripToEdit.Places = Trip.Places;
            // TripToEdit.Trails = Trip.Trails;

            db.Trip.Update(TripToEdit);
            db.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Trip = db.Trip.FirstOrDefault(t => t.Id == id);

            if (Trip == null)
            {
                return NotFound();
            }

            db.Trip.Remove(Trip);
            db.SaveChanges();

            return NoContent();
        }
    }
}
