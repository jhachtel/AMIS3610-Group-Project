using System;
using System.Collections.Generic;

namespace AMIS3610.GroupProject.Api.Models
{
    public class Trail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        public List<Place> Places = new List<Place>();

        public void ChangeId(int newId) => Id = newId;
        public void ChangeName(string newName) => Name = newName;
        public void ChangeDescription(string newDescription) => Description = newDescription;
        public void ChangeLink(string newLink) => Link = newLink;

        public void AssociatePlace(Place place)
        {
            if (place == null)
            {
                throw new ArgumentNullException(nameof(place));
            }

            Places.Add(place);
        }

        public void DisassociatePlace(Place place)
        {
            if (place == null)
            {
                throw new ArgumentNullException(nameof(place));
            }

            Places.Remove(place);
        }
    }
}