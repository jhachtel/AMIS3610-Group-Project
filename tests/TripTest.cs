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

            var OldGear = new Gear()
                {
                    Id = 999999902,
                    Name = "Old Gear",
                    Brand = "Old Gear",
                    Type = "Old Type",
                    Description = "Old Description.",
                    Link = "https://www.merriam-webster.com/dictionary/gear"
                };

            var NewGear = new Gear()
                {
                    Id = 999999903,
                    Name = "New Gear",
                    Brand = "New Brand",
                    Type = "New Type",
                    Description = "New Description.",
                    Link = "https://www.thesaurus.com/browse/gear"
                };

            var OldPerson = new Person()
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

            var NewPerson = new Person()
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

            var OldTrail = new Trail()
                {
                    Id = 999999906,
                    Name = "Old Trail",
                    Place = null,
                    Description = "Old Description.",
                    Link = "https://www.merriam-webster.com/dictionary/trail"
                };

            var NewTrail = new Trail()
                {
                    Id = 999999907,
                    Name = "New Trail",
                    Place = null,
                    Description = "New Description.",
                    Link = "https://www.thesaurus.com/browse/trail"
                };

            var TripToTest = new Trip()
                {
                    Id = 999999908,
                    Name = "The Trip to Test",
                    Description = "Test Description"
                };
            
            TripToTest.AssociatePerson(OldPerson);
            TripToTest.AssociateGear(OldGear);
            TripToTest.AssociatePlace(OldPlace);
            TripToTest.AssociateTrail(OldTrail);

            //Tests...
            var newId = 999999909;
            TripToTest.ChangeId(newId);
            var expectedId = newId;
            var actualId = TripToTest.Id;
            Assert.Equal(expectedId, actualId);
            
            var newName = "New Name";
            TripToTest.ChangeName(newName);
            var expectedName = newName;
            var actualName = TripToTest.Name;
            Assert.Equal(expectedName, actualName);
            
            var newPlace = NewPlace;
            var expectedPlace = newPlace;
            TripToTest.AssociatePlace(newPlace);
            Assert.True(TripToTest.Places.Contains(newPlace));
            TripToTest.DisassociatePlace(OldPlace);
            Assert.False(TripToTest.Places.Contains(OldPlace));
            var actualPlace = TripToTest.Places[0];
            Assert.Same(expectedPlace, actualPlace);
            
            var newGear = NewGear;
            var expectedGear = newGear;
            TripToTest.AssociateGear(newGear);
            Assert.True(TripToTest.GearList.Contains(newGear));
            TripToTest.DisassociateGear(OldGear);
            Assert.False(TripToTest.GearList.Contains(OldGear));
            var actualGear = TripToTest.GearList[0];
            Assert.Same(expectedGear, actualGear);
            
            var newPerson = NewPerson;
            var expectedPerson = newPerson;
            TripToTest.AssociatePerson(newPerson);
            Assert.True(TripToTest.Companions.Contains(newPerson));
            TripToTest.DisassociatePerson(OldPerson);
            Assert.False(TripToTest.Companions.Contains(OldPerson));
            var actualPerson = TripToTest.Companions[0];
            Assert.Same(expectedPerson, actualPerson);
            
            var newTrail = NewTrail;
            var expectedTrail = newTrail;
            TripToTest.AssociateTrail(newTrail);
            Assert.True(TripToTest.Trails.Contains(newTrail));
            TripToTest.DisassociateTrail(OldTrail);
            Assert.False(TripToTest.Trails.Contains(OldTrail));
            var actualTrail = TripToTest.Trails[0];
            Assert.Same(expectedTrail, actualTrail);

            var newDescription = "Went to see the old cathedral";
            TripToTest.ChangeDescription(newDescription);
            var expectedDescription = newDescription;
            var actualDescription = TripToTest.Description;
            Assert.Equal(expectedDescription, actualDescription);
        }
    }
}