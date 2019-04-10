using System;
using Xunit;
using AMIS3610.GroupProject.Api.Models;

namespace tests
{
    public class BookTest
    {
        public BookTest()
        {
        }

        [Fact]
        public void ChangePublicationDate()
        {
            //Arrange
            var book = new Book()
            {
                Id = 1,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };

            //Act
            var newPublicationDate = DateTime.Now.AddMonths(2);
            book.ChangePublicationDate(newPublicationDate);

            //Assert
            var expectedPublicationDate = newPublicationDate.ToShortDateString();
            var actualPublicationDate = book.PublishDate.ToShortDateString();

            Assert.Equal(expectedPublicationDate, actualPublicationDate);

        }

        [Fact]
        public void ChangeAuthor()
        {
            //Arrange
            var book = new Book()
            {
                Id = 2,
                Title = "Artificial Intelligence: A Modern Approach (3rd Edition)",
                Author = new Author()
                {
                    Id = 66,
                    Name = "Mary Poppins",
                    Bio = ""
                },
                PublishDate = new DateTime(2009, 12, 11),
                Publisher = "Pearson"
            };

            //Act
            var newAuthor = new Author()
                {
                    Id = 67,
                    Name = "Stuart Russell, Peter Norvig",
                    Bio = ""
                };
            book.ChangeAuthor(newAuthor);

            //Assert
            var expectedAuthor = newAuthor;
            var actualAuthor = book.Author;

            Assert.Equal(expectedAuthor, actualAuthor);

        }
    }
}
