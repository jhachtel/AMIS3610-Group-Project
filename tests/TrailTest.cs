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
            var placeToAdd = new Place()
                {
                    Id = 999999901,
                    Name = "Place to Add",
                    Location = "New Location",
                    Type = "New Type",
                    Description = "New Description.",
                    Link = "https://www.thesaurus.com/browse/place"
                };
            Assert.NotNull(placeToAdd);

            var trailToTest = new Trail()
                {
                    Id = 999999902,
                    Name = "Trail to Test",
                    Description = "Trail to test description.",
                    Link = "http://www.google.com/"
                };
            Assert.NotNull(trailToTest);

            //Testing the id field
            var newId = 999999903;
            trailToTest.ChangeId(newId);
            var expectedId = newId;
            var actualId = trailToTest.Id;
            Assert.Equal(expectedId, actualId);

            //Testing the name field            
            var newName = "New Name";
            trailToTest.ChangeName(newName);
            var expectedName = newName;
            var actualName = trailToTest.Name;
            Assert.Equal(expectedName, actualName);
            
            //Testing the places list
            var place = placeToAdd;
            var expectedPlace = place;
            Assert.Empty(trailToTest.Places);
            trailToTest.AssociatePlace(place);
            Assert.NotEmpty(trailToTest.Places);
            var actualPlace = trailToTest.Places[0];
            Assert.Same(expectedPlace, actualPlace);
            trailToTest.DisassociatePlace(place);
            Assert.Empty(trailToTest.Places);

            //Testing the description field            
            var newDescription = "New Description.";
            trailToTest.ChangeDescription(newDescription);
            var expectedDescription = newDescription;
            var actualDescription = trailToTest.Description;
            Assert.Equal(expectedDescription, actualDescription);

            //Testing the link field            
            var newLink = "https://www.amazon.com/";
            trailToTest.ChangeLink(newLink);
            var expectedLink = newLink;
            var actualLink = trailToTest.Link;
            Assert.Equal(expectedLink, actualLink);
        }
    }
}
