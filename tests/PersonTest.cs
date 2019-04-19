using System;
using Xunit;
using AMIS3610.GroupProject.Api.Models;

namespace AMIS3610.GroupProject.Api.Tests
{
    public class PersonTest
    {
        public PersonTest()
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
                    Brand = "Old Brand",
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

            var OldFriend = new Person()
                {
                    Id = 999999904,
                    Name = "Old Friend",
                    Email = "old@email.com",
                    Bio = "Old Bio",
                    Friends = null,
                    Gear = null,
                    Places = null,
                    Trails = null,
                    Trips = null
                };

            var NewFriend = new Person()
                {
                    Id = 999999905,
                    Name = "New Friend",
                    Email = "old@email.com",
                    Bio = "Old Bio",
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
                    Link = "https://www.merriam-webster.com/dictionary/description"
                };

            var NewTrail = new Trail()
                {
                    Id = 999999907,
                    Name = "New Trail",
                    Place = null,
                    Description = "New Description.",
                    Link = "https://www.thesaurus.com/browse/description"
                };

            var OldTrip = new Trip()
                {
                    Id = 999999908,
                    Name = "Old Trip",
                    Description = "Old Description"
                };

            var NewTrip = new Trip()
                {
                    Id = 999999909,
                    Name = "New Trip",
                    Description = "New Description."
                };

            var PersonToTest = new Person()
                {
                    Id = 999999910,
                    Name = "Person to Test",
                    Email = "persontotest@email.com",
                    Bio = "Test Bio",
                    Friends = null,
                    Gear = null,
                    Places = null,
                    Trails = null,
                    Trips = null
                };
            
            PersonToTest.AssociatePerson(OldFriend);
            PersonToTest.AssociateGear(OldGear);
            PersonToTest.AssociatePlace(OldPlace);
            PersonToTest.AssociateTrail(OldTrail);
            PersonToTest.AssociateTrip(OldTrip);

            //Tests...
            var newId = 999999911;
            PersonToTest.ChangeId(newId);
            var expectedId = newId;
            var actualId = PersonToTest.Id;
            Assert.Equal(expectedId, actualId);
            
            var newName = "New Name";
            PersonToTest.ChangeName(newName);
            var expectedName = newName;
            var actualName = PersonToTest.Name;
            Assert.Equal(expectedName, actualName);
            
            var newEmail = "new@email.com";
            PersonToTest.ChangeEmail(newEmail);
            var expectedEmail = newEmail;
            var actualEmail = PersonToTest.Email;
            Assert.Equal(expectedEmail, actualEmail);

            var newBio = "New Bio";
            PersonToTest.ChangeBio(newBio);
            var expectedBio = newBio;
            var actualBio = PersonToTest.Bio;
            Assert.Equal(expectedBio, actualBio);
            
            var newPlace = NewPlace;
            var expectedPlace = newPlace;
            PersonToTest.AssociatePlace(newPlace);
            Assert.True(PersonToTest.Places.Contains(newPlace));
            PersonToTest.DisassociatePlace(OldPlace);
            Assert.False(PersonToTest.Places.Contains(OldPlace));
            var actualPlace = PersonToTest.Places[0];
            Assert.Same(expectedPlace, actualPlace);
            
            var newGear = NewGear;
            var expectedGear = newGear;
            OldFriend.AssociateGear(newGear);
            Assert.True(PersonToTest.Gear.Contains(newGear));
            OldFriend.DisassociateGear(OldGear);
            Assert.False(PersonToTest.Gear.Contains(OldGear));
            var actualGear = PersonToTest.Gear[0];
            Assert.Same(expectedGear, actualGear);
            
            var newFriend = NewFriend;
            var expectedFriend = newFriend;
            PersonToTest.AssociatePerson(newFriend);
            Assert.True(PersonToTest.Friends.Contains(newFriend));
            PersonToTest.DisassociatePerson(OldFriend);
            Assert.False(PersonToTest.Friends.Contains(OldFriend));
            var actualFriend = PersonToTest.Friends[0];
            Assert.Same(expectedFriend, actualFriend);
            
            var newTrail = NewTrail;
            var expectedTrail = newTrail;
            PersonToTest.AssociateTrail(newTrail);
            Assert.True(PersonToTest.Trails.Contains(newTrail));
            PersonToTest.DisassociateTrail(OldTrail);
            Assert.False(PersonToTest.Trails.Contains(OldTrail));
            var actualTrail = PersonToTest.Trails[0];
            Assert.Same(expectedTrail, actualTrail);
            
            var newTrip = NewTrip;
            var expectedTrip = newTrip;
            PersonToTest.AssociateTrip(newTrip);
            Assert.True(PersonToTest.Trips.Contains(newTrip));
            PersonToTest.DisassociateTrip(OldTrip);
            Assert.False(PersonToTest.Trips.Contains(OldTrip));
            var actualTrip = PersonToTest.Trips[0];
            Assert.Same(expectedTrip, actualTrip);

        }
    }
}
