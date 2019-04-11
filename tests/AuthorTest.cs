using System;
using Xunit;

namespace AMIS3610.GroupProject.Api.Tests
{
    public class AuthorTest
    {
        public AuthorTest()
        {
        }

        [Fact]
        public void UpdateBio()
        {
            //Arrange
            var author = new Author()
            {
                Id = 420,
                Name = "Willie Nelson",
                Bio = "Willie Hugh Nelson (born April 29, 1933) is an American singer, songwriter, musician, actor, producer, author, poet, and activist.[1] The critical success of the album Shotgun Willie (1973), combined with the critical and commercial success of Red Headed Stranger (1975) and Stardust (1978), made Nelson one of the most recognized artists in country music. He was one of the main figures of outlaw country, a subgenre of country music that developed in the late 1960s as a reaction to the conservative restrictions of the Nashville sound. Nelson has acted in over 30 films, co-authored several books, and has been involved in activism for the use of biofuels and the legalization of marijuana."
            };

            //Act
            var newBio = "Willie Nelson was born on April 29, 1933, in Abbott, Texas. ... Nelson got his first guitar at the early age of six and started writing his own songs soon thereafter. His famous gospel song “Family Bible” draws from his early exposure to religious music. He sold the song to his guitar teacher for $50.";
            author.UpdateBio(newBio);

            //Assert
            var expectedBio = newBio;
            var actualBio = author.Bio;

            Assert.Equal(expectedBio, actualBio);

        }
    }
}
