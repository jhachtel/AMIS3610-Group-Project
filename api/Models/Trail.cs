using System;

namespace AMIS3610.GroupProject.Api.Models
{
    public class Trail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public Place Place{ get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        public void ChangeId(int newId) => Id = newId;
        public void ChangeName(string newName) => Name = newName;
        //public void ChangePlace(Place newPlace) => Place = newPlace;
        public void ChangeDescription(string newDescription) => Description = newDescription;
        public void ChangeLink(string newLink) => Link = newLink;
    }
}