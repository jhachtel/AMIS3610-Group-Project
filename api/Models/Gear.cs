using System;

namespace AMIS3610.GroupProject.Api.Models
{
    public class Gear
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        public void ChangeId(int newId) => this.Id = newId;
        public void ChangeBrand(string newBrand) => this.Brand = newBrand;
        public void ChangeName(string newName) => this.Name = newName;
        public void ChangeType(string newType) => this.Type = newType;
        public void ChangeDescription(string newDescription) => this.Description = newDescription;
        public void ChangeLink(string newLink) => this.Link = newLink;
    }
}