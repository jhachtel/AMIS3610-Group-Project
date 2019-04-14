using System;

namespace AMIS3610.GroupProject.Api.Models
{
    public class Place
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        
        public void ChangeId(int newId)
        {
            this.Id = newId;
        }

        public void ChangeName(string newName)
        {
            this.Name = newName;
        }

        public void ChangeLocation(string newLocation)
        {
            this.Location = newLocation;
        }

        public void ChangeType(string newType)
        {
            this.Type = newType;
        }

        public void ChangeDescription(string newDescription)
        {
            this.Description = newDescription;
        }

    }
}