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

        public List<Person> Friends { get; set; }
        public List<Gear>   Gear { get; set; }
        public List<Place>  Places { get; set; }
        public List<Trail>  Trails { get; set; }
        public List<Trip>   Trips { get; set; }

        public void ChangeId(int newId) => this.Id = newId;
        public void ChangeName(string newName) => this.Name = newName;
        public void ChangeEmail(string newEmail) => this.Email = newEmail;
        public void ChangeBio(string newBio) => this.Bio = newBio;

        public void AssociatePerson(Person person) => this.Friends.Add(person);
        public void AssociateGear(Gear gear) => this.Gear.Add(gear);
        public void AssociatePlace(Place place) => this.Places.Add(place);
        public void AssociateTrail(Trail trail) => this.Trails.Add(trail);
        public void AssociateTrip(Trip trip) => this.Trips.Add(trip);
        
        public void DisassociatePerson(Person person) => this.Friends.Remove(person);
        public void DisassociateGear(Gear gear) => this.Gear.Remove(gear);
        public void DisassociatePlace(Place place) => this.Places.Remove(place);
        public void DisassociateTrail(Trail trail) => this.Trails.Remove(trail);
        public void DisassociateTrip(Trip trip) => this.Trips.Remove(trip);
    }
}