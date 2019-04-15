using System;
using System.Collections.Generic;

namespace AMIS3610.GroupProject.Api.Models
{
    public class Person
    {
        public int      Id { get; set; }
        public string   Name { get; set; }
        public string   Email { get; set; }
        public string   Bio { get; set; }

        // public List<Person> Friends { get; set; }
        // public List<Gear>   Gear { get; set; }
        // public List<Place>  Places { get; set; }
        // public List<Trail>  Trails { get; set; }
        // public List<Trip>   Trips { get; set; }

        // public void ChangeId(int newId) => this.Id = newId;
        // public void ChangeName(string newName) => this.Name = newName;
        // public void ChangeEmail(string newEmail) => this.Email = newEmail;
        // public void ChangeBio(string newBio) => this.Bio = newBio;

        // public void AssociatePerson(Person p) => Friends.Add(p);
        // public void AssociateGear(Gear g) => Gear.Add(g);
        // public void AssociatePlace(Place pl) => Places.Add(pl);
        // public void AssociateTrail(Trail tl) => Trails.Add(tl);
        // public void AssociateTrip(Trip tp) => Trips.Add(tp);
        
        // public void DisassociatePerson(Person pn) => Friends.Remove(pn);
        // public void DisassociateGear(Gear gr) => Gear.Remove(gr);
        // public void DisassociatePlace(Place plc) => Places.Remove(plc);
        // public void DisassociateTrail(Trail tr) => Trails.Remove(tr);
        // public void DisassociateTrip(Trip t) => Trips.Remove(t);
    }
}