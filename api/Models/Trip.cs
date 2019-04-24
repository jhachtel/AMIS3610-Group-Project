using System;
using System.Collections.Generic;

namespace AMIS3610.GroupProject.Api.Models
{
    public class Trip
    {
        public int Id{get; set;}
        public string Name{get; set;}
        public string Description { get; set; }

        public List<Person> Companions = new List<Person>();
        public List<Item>   ItemList = new List<Item>();
        public List<Place>  Places = new List<Place>();
        public List<Trail>  Trails = new List<Trail>();

        public void ChangeId(int newId) => Id = newId;
        public void ChangeName(string newName) => Name = newName;
        public void ChangeDescription(string newDescription) => Description = newDescription;

        public void AssociatePerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }

            Companions.Add(person);
        }

        public void AssociateItem(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            ItemList.Add(item);
        }

        public void AssociatePlace(Place place)
        {
            if (place == null)
            {
                throw new ArgumentNullException(nameof(place));
            }

            Places.Add(place);
        }

        public void AssociateTrail(Trail trail)
        {
            if (trail == null)
            {
                throw new ArgumentNullException(nameof(trail));
            }

            Trails.Add(trail);
        }

        public void DisassociatePerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }

            Companions.Remove(person);
        }

        public void DisassociateItem(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            ItemList.Remove(item);
        }

        public void DisassociatePlace(Place place)
        {
            if (place == null)
            {
                throw new ArgumentNullException(nameof(place));
            }

            Places.Remove(place);
        }

        public void DisassociateTrail(Trail trail)
        {
            if (trail == null)
            {
                throw new ArgumentNullException(nameof(trail));
            }

            Trails.Remove(trail);
        }
    }
}