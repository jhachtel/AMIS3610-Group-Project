using System;

namespace AMIS3610.GroupProject.Api.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        public void ChangeId(int newId) => Id = newId;
        public void ChangeBrand(string newBrand) => Brand = newBrand;
        public void ChangeName(string newName) => Name = newName;
        public void ChangeType(string newType) => Type = newType;
        public void ChangeDescription(string newDescription) => Description = newDescription;
        public void ChangeLink(string newLink) => Link = newLink;
    }
}