using System;

namespace AMIS3610.GroupProject.Api.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Author Author { get; set; }

        public string ISBN { get; set; }

        public DateTime PublishDate{ get; set; }

        public string Publisher { get; set; }

        
        public void ChangePublicationDate(DateTime newPublishDate)
        {
            this.PublishDate = newPublishDate;
        }

        public void ChangeAuthor(Author newAuthor)
        {
            this.Author = newAuthor;
        }

    }
}