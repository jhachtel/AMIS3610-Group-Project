using System;
using System.Collections.Generic;

namespace AMIS3610.GroupProject.Api.Models
{
    public class Author
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public string Bio { get; set; }

        public List<Book> Titles { get; set; }

        public void ChangeId(int id)
        {
            this.Id = id;
        }

        public void UpdateBio(String bio)
        {
            this.Bio = bio;
        }

    }
}