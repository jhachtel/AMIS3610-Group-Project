using System;
using Xunit;
using AMIS3610.GroupProject.Api.Models;

namespace AMIS3610.GroupProject.Api.Tests
{
    public class TrailTest
    {
        public TrailTest()
        {
        }

        [Fact]
        public void ChangeAttributes()
        {
            var OldPlace = new Place()
                {
                    Id = 999999900,
                    Name = "Old Place",
                    Location = "Old Location",
                    Type = "Old Type",
                    Description = "Old Description.",
                    Link = "https://www.merriam-webster.com/dictionary/place"
                };

            var NewPlace = new Place()
                {
                    Id = 999999901,
                    Name = "New Place",
                    Location = "New Location",
                    Type = "New Type",
                    Description = "New Description.",
                    Link = "https://www.thesaurus.com/browse/place"
                };

            var TrailToTest = new Trail()
                {
                    Id = 999999902,
                    Name = "Trail to Test",
                    Place = null,
                    Description = "Trail to test description.",
                    Link = "http://www.google.com/"
                };

            var newId = 999999903;
            TrailToTest.ChangeId(newId);
            var expectedId = newId;
            var actualId = TrailToTest.Id;
            Assert.Equal(expectedId, actualId);
            
            var newName = "New Name";
            TrailToTest.ChangeName(newName);
            var expectedName = newName;
            var actualName = TrailToTest.Name;
            Assert.Equal(expectedName, actualName);
            
            var newPlace = NewPlace;
            TrailToTest.ChangePlace(NewPlace);
            var expectedPlace = newPlace;
            var actualPlace = TrailToTest.Place;
            Assert.Equal(expectedPlace, actualPlace);

            var newDescription = "New Description.";
            TrailToTest.ChangeDescription(newDescription);
            var expectedDescription = newDescription;
            var actualDescription = TrailToTest.Description;
            Assert.Equal(expectedDescription, actualDescription);
            
            var newLink = "https://www.amazon.com/";
            TrailToTest.ChangeLink(newLink);
            var expectedLink = newLink;
            var actualLink = TrailToTest.Link;
            Assert.Equal(expectedLink, actualLink);
        }
    }
}
