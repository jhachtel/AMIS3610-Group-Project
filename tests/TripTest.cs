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
            var oldPlace = new Place()
                {
                    Id = 999999900,
                    Name = "Old Place",
                    Location = "Old Location",
                    Type = "Old Type",
                    Description = "Old Description.",
                    Link = "https://www.merriam-webster.com/dictionary/place"
                };

            var newPlace = new Place()
                {
                    Id = 999999901,
                    Name = "New Place",
                    Location = "New Location",
                    Type = "New Type",
                    Description = "New Description.",
                    Link = "https://www.thesaurus.com/browse/place"
                };

            var oldGear = new Gear()
                {
                    Id = 999999902,
                    Name = "Old Gear",
                    Brand = "Old Gear",
                    Type = "Old Type",
                    Description = "Old Description.",
                    Link = "https://www.merriam-webster.com/dictionary/gear"
                };

            var newGear = new Gear()
                {
                    Id = 999999903,
                    Name = "New Gear",
                    Brand = "New Brand",
                    Type = "New Type",
                    Description = "New Description.",
                    Link = "https://www.thesaurus.com/browse/gear"
                };

            var oldPerson = new Person()
                {
                    Id = 999999904,
                    Name = "Old Person",
                    Email = "old@email.com",
                    Bio = "Old Bio",
                    Friends = null,
                    Gear = null,
                    Places = null,
                    Trails = null,
                    Trips = null
                };

            var newPerson = new Person()
                {
                    Id = 999999905,
                    Name = "New Person",
                    Email = "new@email.com",
                    Bio = "New Bio",
                    Friends = null,
                    Gear = null,
                    Places = null,
                    Trails = null,
                    Trips = null
                };

            var oldTrail = new Trail()
                {
                    Id = 999999906,
                    Name = "Old Trail",
                    Place = null,
                    Description = "Old Description.",
                    Link = "https://www.merriam-webster.com/dictionary/trail"
                };

            var newTrail = new Trail()
                {
                    Id = 999999907,
                    Name = "New Trail",
                    Place = null,
                    Description = "New Description.",
                    Link = "https://www.thesaurus.com/browse/trail"
                };

            var tripToTest = new Trip()
                {
                    Id = 999999908,
                    Name = "The Trip to Test",
                    Description = "Test Description"
                };
            
            tripToTest.AssociatePerson(oldPerson);
            tripToTest.AssociateGear(oldGear);
            tripToTest.AssociatePlace(oldPlace);
            tripToTest.AssociateTrail(oldTrail);

            //Tests...
            var newId = 999999909;
            tripToTest.ChangeId(newId);
            var expectedId = newId;
            var actualId = tripToTest.Id;
            Assert.Equal(expectedId, actualId);
            
            var newName = "New Name";
            tripToTest.ChangeName(newName);
            var expectedName = newName;
            var actualName = tripToTest.Name;
            Assert.Equal(expectedName, actualName);
            
            var place = newPlace;
            var expectedPlace = place;
            tripToTest.AssociatePlace(place);
            Assert.True(tripToTest.Places.Contains(place));
            tripToTest.DisassociatePlace(oldPlace);
            Assert.False(tripToTest.Places.Contains(oldPlace));
            var actualPlace = tripToTest.Places[0];
            Assert.Same(expectedPlace, actualPlace);
            
            var gear = newGear;
            var expectedGear = gear;
            tripToTest.AssociateGear(gear);
            Assert.True(tripToTest.GearList.Contains(gear));
            tripToTest.DisassociateGear(oldGear);
            Assert.False(tripToTest.GearList.Contains(oldGear));
            var actualGear = tripToTest.GearList[0];
            Assert.Same(expectedGear, actualGear);
            
            var person = newPerson;
            var expectedPerson = person;
            tripToTest.AssociatePerson(person);
            Assert.True(tripToTest.Companions.Contains(person));
            tripToTest.DisassociatePerson(oldPerson);
            Assert.False(tripToTest.Companions.Contains(oldPerson));
            var actualPerson = tripToTest.Companions[0];
            Assert.Same(expectedPerson, actualPerson);
            
            var trail = newTrail;
            var expectedTrail = trail;
            tripToTest.AssociateTrail(trail);
            Assert.True(tripToTest.Trails.Contains(trail));
            tripToTest.DisassociateTrail(oldTrail);
            Assert.False(tripToTest.Trails.Contains(oldTrail));
            var actualTrail = tripToTest.Trails[0];
            Assert.Same(expectedTrail, actualTrail);

            var newDescription = "Went to see the old cathedral";
            tripToTest.ChangeDescription(newDescription);
            var expectedDescription = newDescription;
            var actualDescription = tripToTest.Description;
            Assert.Equal(expectedDescription, actualDescription);
        }
    }
}