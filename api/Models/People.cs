using System;

namespace AMIS3610.GroupProject.Api.Models
{
    public class People
    {
        public int Id{get; set;}

        public string Name{get; set;}

        public string Contactinfo{get; set;}

        public string Bio{get; set;}

        public void ChangeId(int newId)
        {
            this.Id = newId;
        }

        public void ChangeName(string newName)
        {
            this.Name = newName;
        }
        public void ChangeContact(string newContactinfo)
        {
            this.Contactinfo= newContactinfo;
        }
        public void ChangeBio(string newBio)
        {
            this.Bio = newBio;
        }
    }
}