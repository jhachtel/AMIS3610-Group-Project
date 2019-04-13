using System.Linq;
using AMIS3610.GroupProject.Api.Data;
using AMIS3610.GroupProject.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AMIS3610.GroupProject.Api.Controllers
{
    [Route("api/Trip")]
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
                        Name="Lane Jacobson",
                        Place = new Place()
                        {
                            Id=26,
                            Name="Garden of the Gods",
                            Location="Colorado, USA",
                            Type ="Hiking Trail",
                            Description= "Sandstone everywhere!"
                        },
                        Gear= new Gear()
                        {
                            Id = 6,
                            Name ="Osprey Kestrel 28 Pack - 2018 - Men's",
                            Brand ="REI",
                            Type="Backpack",
                            Description ="Atilon framesheet spreads the load across the entire back panel to the peripheral frame Tuckaway ice tool loop and bungee tie-offs; dual front-panel daisy chains; Stow-on-the-Go trekking pole attachment"
                        },
                        People= new People()
                        {
                            Id=1,
                            Name="Lane Jacobson",
                            Contactinfo="555-865-8795 or @ hikeordie@live.com",
                            Bio="Hiker of the Alps, I call myself the surfer of earth"
                        },
                        Description = "Perfect for treks outside on a cool day or layered under a coat when wet weather hits, the men's REI Co-op fleece jacket delivers all-purpose outdoor warmth."
                    });
                    this.db.Trip.Add(new Trip()
                    {
                         Id = 1,
                        Name="Lane Jacobson",
                        Place = new Place()
                        {
                            Id=42,
                            Name="Akiabara for life",
                            Location="Tokyo, Japan",
                            Type ="City Travel",                           
                        },
                        Gear= new Gear()
                        {
                            Id = 7,
                            Name ="REI Co-op Big Haul 40 Duffel ",
                            Brand ="REI",
                            Type="Bag",
                            Description ="Rugged ripstop nylon upper combines with a tough ballistic nylon base for durability Versatile carrying options�crossbody strap, removable duffel handles and stowable backpack straps Side and end handles make it easy to grab and go"
                        },
                        People= new People()
                        {
                            Id=1,
                            Name="Trisha Smith",
                            Contactinfo="322-8569-9888",
                            Bio="Ive been to 25 countries so far! Shooting to see them all before I die"
                        },
                            Description= "The Nerdiest place on earth"                    });
                    this.db.Trip.Add(new Trip()
                    {
                        Id = 75,
                        Name="Maribosa Schleep",
                        Place = new Place()
                        {
                            Id=26,
                            Name="Disney!!",
                            Location="Florida, USA",
                            Type ="Amusement Park",
                            Description= "Animal Kingdom was a letdown"
                        },
                        People= new People()
                        {
                            Id=33,
                            Name="Jack Sully",
                            Contactinfo="4496-Spr@hotmail.com",
                        },
                        Description = "First trip here. Its so hot and crowded. I'm starting to think that this was a waste of money"
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
            var Trip = db.Trip.FirstOrDefault(g => g.Id == id);

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

            var TripToEdit = db.Trip.FirstOrDefault(g => g.Id == id);
            if (TripToEdit == null)
            {
                return NotFound();
            }

            TripToEdit.Name = Trip.Name;
            TripToEdit.Place = Trip.Place;
            TripToEdit.Gear = Trip.Gear;
            TripToEdit.People = Trip.People;
            TripToEdit.Description = Trip.Description;

            db.Trip.Update(TripToEdit);
            db.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Trip = db.Trip.FirstOrDefault(g => g.Id == id);

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
