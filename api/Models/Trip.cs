using System;
using System.Collections.Generic;

namespace AMIS3610.GroupProject.Api.Models
{
    public class Trip
    {
        public int Id{get; set;}
        public string Name{get; set;}
        public string Description { get; set; }

        public List<Person> Companions { get; set; }
        public List<Gear>   GearList { get; set; }
        public List<Place>  Places { get; set; }
        public List<Trail>  Trails { get; set; }

        public void ChangeId(int newId) => this.Id = newId;
        public void ChangeName(string newName) => this.Name = newName;
        public void ChangeDescription(string newDescription) => this.Description = newDescription;

        public void AssociatePerson(Person person) => this.Companions.Add(person);
        public void AssociateGear(Gear gear) => this.GearList.Add(gear);
        public void AssociatePlace(Place place) => this.Places.Add(place);
        public void AssociateTrail(Trail trail) => this.Trails.Add(trail);
        
        public void DisassociatePerson(Person person) => this.Companions.Remove(person);
        public void DisassociateGear(Gear gear) => this.GearList.Remove(gear);
        public void DisassociatePlace(Place place) => this.Places.Remove(place);
        public void DisassociateTrail(Trail trail) => this.Trails.Remove(trail);
    }
}