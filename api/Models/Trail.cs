using System;

namespace AMIS3610.GroupProject.Api.Models
{
    public class Trail
    {
        public int Id { get; set;}

        public string Name {get; set;}

        public Place place{get; set;}
        public string Description { get; set; }

        public void ChangeId(int newId)
        {
            this.Id = newId;
        }

         public void ChangeName(string newName)
        {
            this.Name = newName;
        }

        public void ChangeDescription(string newDescription)
        {
            this.Description = newDescription;
        }
    }
}