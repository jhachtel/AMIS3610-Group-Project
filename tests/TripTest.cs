using System;
using Xunit;
using AMIS3610.GroupProject.Api.Models;
using System.Collections.Generic;

namespace AMIS3610.GroupProject.Api.Tests
{
    public class TripTest
    {
        public TripTest()
        {
        }

        [Fact]
        public void ChangeAttributes()
        {
            var companionToAdd = new Person()
                {
                    Id = 999999901,
                    Name = "Companion to Add",
                    Email = "companion@test.com",
                    Bio = "New Description."
                };
            Assert.NotNull(companionToAdd);

            var gearToAdd = new Gear()
                {
                    Id = 999999903,
                    Name = "Gear to Add",
                    Brand = "New Brand",
                    Type = "New Type",
                    Description = "New Description.",
                    Link = "https://www.thesaurus.com/browse/gear"
                };
            Assert.NotNull(gearToAdd);

            var placeToAdd = new Place()
                {
                    Id = 999999905,
                    Name = "Place to Add",
                    Location = "New Location",
                    Type = "New Type",
                    Description = "New Description.",
                    Link = "https://www.thesaurus.com/browse/place"
                };
            Assert.NotNull(placeToAdd);

            var trailToAdd = new Trail()
                {
                    Id = 999999907,
                    Name = "Trail to Add",
                    Place = null,
                    Description = "New Description.",
                    Link = "https://www.thesaurus.com/browse/trail"
                };
            Assert.NotNull(trailToAdd);

            var tripToTest = new Trip()
                {
                    Id = 999999908,
                    Name = "The Trip to Test",
                    Description = "Test Description"
                };
            Assert.NotNull(tripToTest);

            //Testing the id field
            var newId = 999999909;
            tripToTest.ChangeId(newId);
            var expectedId = newId;
            var actualId = tripToTest.Id;
            Assert.Equal(expectedId, actualId);
            
            //Testing the name field
            var newName = "New Trip Name";
            tripToTest.ChangeName(newName);
            var expectedName = newName;
            var actualName = tripToTest.Name;
            Assert.Equal(expectedName, actualName);

            //Testing the description field
            var newDescription = "New Test Description";
            tripToTest.ChangeDescription(newDescription);
            var expectedDescription = newDescription;
            var actualDescription = tripToTest.Description;
            Assert.Equal(expectedDescription, actualDescription);
            
            //Testing the places list
            var place = placeToAdd;
            var expectedPlace = place;
            Assert.Empty(tripToTest.Places);
            tripToTest.AssociatePlace(place);
            Assert.NotEmpty(tripToTest.Places);
            var actualPlace = tripToTest.Places[0];
            Assert.Same(expectedPlace, actualPlace);
            tripToTest.DisassociatePlace(place);
            Assert.Empty(tripToTest.Places);
            
            //Testing the gear list
            var gear = gearToAdd;
            var expectedGear = gear;
            Assert.Empty(tripToTest.GearList);
            tripToTest.AssociateGear(gear);
            Assert.NotEmpty(tripToTest.GearList);
            var actualGear = tripToTest.GearList[0];
            Assert.Same(expectedGear, actualGear);
            tripToTest.DisassociateGear(gear);
            Assert.Empty(tripToTest.GearList);
            
            //Testing the companions list
            var companion = companionToAdd;
            var expectedFriend = companion;
            Assert.Empty(tripToTest.Companions);
            tripToTest.AssociatePerson(companion);
            Assert.NotEmpty(tripToTest.Companions);
            var actualFriend = tripToTest.Companions[0];
            Assert.Same(expectedFriend, actualFriend);
            tripToTest.DisassociatePerson(companion);
            Assert.Empty(tripToTest.Companions);
            
            //Testing the trails list
            var trail = trailToAdd;
            var expectedTrail = trail;
            Assert.Empty(tripToTest.Trails);
            tripToTest.AssociateTrail(trail);
            Assert.NotEmpty(tripToTest.Trails);
            var actualTrail = tripToTest.Trails[0];
            Assert.Same(expectedTrail, actualTrail);
            tripToTest.DisassociateTrail(trail);
            Assert.Empty(tripToTest.Trails);
        }
    }
}