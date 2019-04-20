using System;
using Xunit;
using AMIS3610.GroupProject.Api.Models;

namespace AMIS3610.GroupProject.Api.Tests
{
    public class PlaceTest
    {
        public PlaceTest()
        {
        }

        [Fact]
        public void ChangeAttributes()
        {
            var PlaceToTest = new Place()
                {
                    Id = 999999900,
                    Name = "Place to Test",
                    Location = "Test Location",
                    Type = "Test Type",
                    Description = "Test Description.",
                    Link = "https://www.amazon.com/"
                };
            Assert.NotNull(PlaceToTest);

            //Testing the id field
            var newId = 999999901;
            PlaceToTest.ChangeId(newId);
            var expectedId = newId;
            var actualId = PlaceToTest.Id;
            Assert.Equal(expectedId, actualId);

            //Testing the name field
            var newName = "New Name";
            PlaceToTest.ChangeName(newName);
            var expectedName = newName;
            var actualName = PlaceToTest.Name;
            Assert.Equal(expectedName, actualName);

            //Testing the location field
            var newLocation = "New Location";
            PlaceToTest.ChangeLocation(newLocation);
            var expectedLocation = newLocation;
            var actualLocation = PlaceToTest.Location;
            Assert.Equal(expectedLocation, actualLocation);

            //Testing the type field
            var newType = "New Type";
            PlaceToTest.ChangeType(newType);
            var expectedType = newType;
            var actualType = PlaceToTest.Type;
            Assert.Equal(expectedType, actualType);

            //Testing the description field
            var newDescription = "New Description.";
            PlaceToTest.ChangeDescription(newDescription);
            var expectedDescription = newDescription;
            var actualDescription = PlaceToTest.Description;
            Assert.Equal(expectedDescription, actualDescription);

            //Testing the link field
            var newLink = "https://www.wolframalpha.com/";
            PlaceToTest.ChangeLink(newLink);
            var expectedLink = newLink;
            var actualLink = PlaceToTest.Link;
            Assert.Equal(expectedLink, actualLink);
        }
    }
}
