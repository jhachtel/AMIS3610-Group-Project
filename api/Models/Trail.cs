using System;

namespace AMIS3610.GroupProject.Api.Models
{
    public class Trail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Place Place{ get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        public void ChangeId(int newId) => this.Id = newId;
        public void ChangeName(string newName) => this.Name = newName;
        public void ChangePlace(Place newPlace) => this.Place = newPlace;
        public void ChangeDescription(string newDescription) => this.Description = newDescription;
        public void ChangeLink(string newLink) => this.Link = newLink;
    }
}