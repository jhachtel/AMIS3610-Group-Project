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

        public List<Place> Places = new List<Place>();
        public List<Gear> Gear = new List<Gear>();
        public List<Person> Friends = new List<Person>();
        public List<Trail>  Trails = new List<Trail>();
        public List<Trip>   Trips = new List<Trip>();

        public void ChangeId(int newId) => this.Id = newId;
        public void ChangeName(string newName) => this.Name = newName;
        public void ChangeEmail(string newEmail) => this.Email = newEmail;
        public void ChangeBio(string newBio) => this.Bio = newBio;

        public void AssociatePerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }

            Friends.Add(person);
        }

        public void AssociateGear(Gear gear)
        {
            if (gear == null)
            {
                throw new ArgumentNullException(nameof(gear));
            }

            Gear.Add(gear);
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

        public void AssociateTrip(Trip trip)
        {
            if (trip == null)
            {
                throw new ArgumentNullException(nameof(trip));
            }

            Trips.Add(trip);
        }

        public void DisassociatePerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }

            Friends.Remove(person);
        }

        public void DisassociateGear(Gear gear)
        {
            if (gear == null)
            {
                throw new ArgumentNullException(nameof(gear));
            }

            Gear.Remove(gear);
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

        public void DisassociateTrip(Trip trip)
        {
            if (trip == null)
            {
                throw new ArgumentNullException(nameof(trip));
            }

            Trips.Remove(trip);
        }
    }
}