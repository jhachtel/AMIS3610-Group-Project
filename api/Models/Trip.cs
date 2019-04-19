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

        public void ChangeId(int newId) => Id = newId;
        public void ChangeName(string newName) => Name = newName;
        public void ChangeDescription(string newDescription) => Description = newDescription;

        public void AssociatePerson(Person person) => Companions.Add(person);
        public void AssociateGear(Gear gear) => GearList.Add(gear);
        public void AssociatePlace(Place place) => Places.Add(place);
        public void AssociateTrail(Trail trail) => Trails.Add(trail);
        
        public void DisassociatePerson(Person person) => Companions.Remove(person);
        public void DisassociateGear(Gear gear) => GearList.Remove(gear);
        public void DisassociatePlace(Place place) => Places.Remove(place);
        public void DisassociateTrail(Trail trail) => Trails.Remove(trail);
    }
}