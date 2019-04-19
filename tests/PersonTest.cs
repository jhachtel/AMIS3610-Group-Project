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
                    Brand = "Old Brand",
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

            var oldFriend = new Person()
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

            var newFriend = new Person()
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

            var oldTrail = new Trail()
                {
                    Id = 999999906,
                    Name = "Old Trail",
                    Place = null,
                    Description = "Old Description.",
                    Link = "https://www.merriam-webster.com/dictionary/description"
                };

            var newTrail = new Trail()
                {
                    Id = 999999907,
                    Name = "New Trail",
                    Place = null,
                    Description = "New Description.",
                    Link = "https://www.thesaurus.com/browse/description"
                };

            var oldTrip = new Trip()
                {
                    Id = 999999908,
                    Name = "Old Trip",
                    Description = "Old Description"
                };

            var newTrip = new Trip()
                {
                    Id = 999999909,
                    Name = "New Trip",
                    Description = "New Description."
                };

            var personToTest = new Person()
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
            
            personToTest.AssociatePerson(oldFriend);
            personToTest.AssociateGear(oldGear);
            personToTest.AssociatePlace(oldPlace);
            personToTest.AssociateTrail(oldTrail);
            personToTest.AssociateTrip(oldTrip);

            //Tests...
            var newId = 999999911;
            personToTest.ChangeId(newId);
            var expectedId = newId;
            var actualId = personToTest.Id;
            Assert.Equal(expectedId, actualId);
            
            var newName = "New Name";
            personToTest.ChangeName(newName);
            var expectedName = newName;
            var actualName = personToTest.Name;
            Assert.Equal(expectedName, actualName);
            
            var newEmail = "new@email.com";
            personToTest.ChangeEmail(newEmail);
            var expectedEmail = newEmail;
            var actualEmail = personToTest.Email;
            Assert.Equal(expectedEmail, actualEmail);

            var newBio = "New Bio";
            personToTest.ChangeBio(newBio);
            var expectedBio = newBio;
            var actualBio = personToTest.Bio;
            Assert.Equal(expectedBio, actualBio);
            
            var place = newPlace;
            var expectedPlace = place;
            personToTest.AssociatePlace(place);
            Assert.True(personToTest.Places.Contains(place));
            personToTest.DisassociatePlace(oldPlace);
            Assert.False(personToTest.Places.Contains(oldPlace));
            var actualPlace = personToTest.Places[0];
            Assert.Same(expectedPlace, actualPlace);
            
            var gear = newGear;
            var expectedGear = gear;
            oldFriend.AssociateGear(gear);
            Assert.True(personToTest.Gear.Contains(gear));
            oldFriend.DisassociateGear(oldGear);
            Assert.False(personToTest.Gear.Contains(oldGear));
            var actualGear = personToTest.Gear[0];
            Assert.Same(expectedGear, actualGear);
            
            var friend = newFriend;
            var expectedFriend = friend;
            personToTest.AssociatePerson(friend);
            Assert.True(personToTest.Friends.Contains(friend));
            personToTest.DisassociatePerson(oldFriend);
            Assert.False(personToTest.Friends.Contains(oldFriend));
            var actualFriend = personToTest.Friends[0];
            Assert.Same(expectedFriend, actualFriend);
            
            var trail = newTrail;
            var expectedTrail = trail;
            personToTest.AssociateTrail(trail);
            Assert.True(personToTest.Trails.Contains(trail));
            personToTest.DisassociateTrail(oldTrail);
            Assert.False(personToTest.Trails.Contains(oldTrail));
            var actualTrail = personToTest.Trails[0];
            Assert.Same(expectedTrail, actualTrail);
            
            var trip = newTrip;
            var expectedTrip = trip;
            personToTest.AssociateTrip(trip);
            Assert.True(personToTest.Trips.Contains(trip));
            personToTest.DisassociateTrip(oldTrip);
            Assert.False(personToTest.Trips.Contains(oldTrip));
            var actualTrip = personToTest.Trips[0];
            Assert.Same(expectedTrip, actualTrip);

        }
    }
}
