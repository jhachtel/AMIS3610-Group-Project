using System;
using Xunit;
using AMIS3610.GroupProject.Api.Models;
using System.Collections.Generic;

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
            var placeToAdd = new Place()
                {
                    Id = 999999900,
                    Name = "Place to Add",
                    Location = "New Location",
                    Type = "New Type",
                    Description = "New Description.",
                    Link = "https://www.thesaurus.com/browse/place"
                };
            Assert.NotNull(placeToAdd);

            var gearToAdd = new Gear()
                {
                    Id = 999999901,
                    Name = "Gear to Add",
                    Brand = "New Brand",
                    Type = "New Type",
                    Description = "New Description.",
                    Link = "https://www.thesaurus.com/browse/gear"
                };
            Assert.NotNull(gearToAdd);

            var friendToAdd = new Person()
                {
                    Id = 999999905,
                    Name = "Friend to Add",
                    Email = "old@email.com",
                    Bio = "Old Bio"
                };
            Assert.NotNull(friendToAdd);

            var trailToAdd = new Trail()
                {
                    Id = 999999907,
                    Name = "Trail to Add",
                    Description = "New Description.",
                    Link = "https://www.thesaurus.com/browse/description"
                };
            Assert.NotNull(trailToAdd);

            var tripToAdd = new Trip()
                {
                    Id = 999999909,
                    Name = "Trip to Add",
                    Description = "New Description."
                };
            Assert.NotNull(tripToAdd);

            var personToTest = new Person()
                {
                    Id = 999999910,
                    Name = "Person to Test",
                    Email = "persontotest@email.com",
                    Bio = "Test Bio"
                };
            Assert.NotNull(personToTest);

            //Testing the id field
            var newId = 999999911;
            personToTest.ChangeId(newId);
            var expectedId = newId;
            var actualId = personToTest.Id;
            Assert.Equal(expectedId, actualId);
            
            //Testing the name field
            var newName = "New Name";
            personToTest.ChangeName(newName);
            var expectedName = newName;
            var actualName = personToTest.Name;
            Assert.Equal(expectedName, actualName);
            
            //Testing the email field
            var newEmail = "new@email.com";
            personToTest.ChangeEmail(newEmail);
            var expectedEmail = newEmail;
            var actualEmail = personToTest.Email;
            Assert.Equal(expectedEmail, actualEmail);

            //Testing the bio field
            var newBio = "New Bio";
            personToTest.ChangeBio(newBio);
            var expectedBio = newBio;
            var actualBio = personToTest.Bio;
            Assert.Equal(expectedBio, actualBio);
            
            //Testing the places list
            var place = placeToAdd;
            var expectedPlace = place;
            Assert.Empty(personToTest.Places);
            personToTest.AssociatePlace(place);
            Assert.NotEmpty(personToTest.Places);
            var actualPlace = personToTest.Places[0];
            Assert.Same(expectedPlace, actualPlace);
            personToTest.DisassociatePlace(place);
            Assert.Empty(personToTest.Places);
            
            //Testing the gear list
            var gear = gearToAdd;
            var expectedGear = gear;
            Assert.Empty(personToTest.Gear);
            personToTest.AssociateGear(gear);
            Assert.NotEmpty(personToTest.Gear);
            var actualGear = personToTest.Gear[0];
            Assert.Same(expectedGear, actualGear);
            personToTest.DisassociateGear(gear);
            Assert.Empty(personToTest.Gear);

            //Tesing the friends list
            var friend = friendToAdd;
            var expectedFriend = friend;
            Assert.Empty(personToTest.Friends);
            personToTest.AssociatePerson(friend);
            Assert.NotEmpty(personToTest.Friends);
            var actualFriend = personToTest.Friends[0];
            Assert.Same(expectedFriend, actualFriend);
            personToTest.DisassociatePerson(friend);
            Assert.Empty(personToTest.Friends);
            
            //Testing the trails list
            var trail = trailToAdd;
            var expectedTrail = trail;
            Assert.Empty(personToTest.Trails);
            personToTest.AssociateTrail(trail);
            Assert.NotEmpty(personToTest.Trails);
            var actualTrail = personToTest.Trails[0];
            Assert.Same(expectedTrail, actualTrail);
            personToTest.DisassociateTrail(trail);
            Assert.Empty(personToTest.Trails);
            
            //Testing the trips list
            var trip = tripToAdd;
            var expectedTrip = trip;
            Assert.Empty(personToTest.Trips);
            personToTest.AssociateTrip(trip);
            Assert.NotEmpty(personToTest.Trips);
            var actualTrip = personToTest.Trips[0];
            Assert.Same(expectedTrip, actualTrip);
            personToTest.DisassociateTrip(trip);
            Assert.Empty(personToTest.Trips);

        }
    }
}
