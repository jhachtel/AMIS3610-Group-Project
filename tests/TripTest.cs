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
            var Place1 = new Place()
                {
                    Id = 999999998,
                    Name = "Envoy Hotel Tblisi",
                    Location = "Tblisi, Georgia",
                    Type = "Hostel",
                    Description = "Enjoy breathtaking views of Tbilisi from our huge roof top terrace. Step outside and you are smack in the middle of the Old Town area. This is the place to be! Perfectly located, Envoy delivers more than just a bed to sleep in. Sharing your passion for travel, everything has been designed with the modern traveller in mind. Relax in our clean and modern rooms. Meet like-minded travellers in our common room decorated with quirky and fun detail. Enjoy our facilities and services including our new kitchen, Discount on tours, Free WiFi, tasty Free breakfast, Free luggage storage and much more.",
                    Link = "https://www.envoyhostel.com/tbilisi/tbilisi-rooms-rates/"
                };

            var NewPlace = new Place()
                {
                    Id = 999999999,
                    Name = "The Biltmore Hotel Tbilisi",
                    Location = "Tblisi, Georgia",
                    Type = "Hotel",
                    Description = "The Biltmore Hotel Tbilisi is the first glass skyscraper in Georgia and the highest hotel in the Caucasus Region. Offering astonishing views, it is ideally situated within the historical and cultural district of Georgia’s capital city. The grand lobby showcasing polished marble floors, crystal chandeliers and enduring pillars, echoes the nostalgia of a bygone era and resonates the glamour and prestige of the social elite and transports guests into an envelope of luxury, unseen or experienced by others before.",
                    Link = "https://www.millenniumhotels.com/en/tbilisi/the-biltmore-hotel-tbilisi/"
                };

            var Gear1 = new Gear()
                {
                    Id = 999999998,
                    Name = "SINE 35",
                    Brand = "Kelty",
                    Type = "Sleeping Bag",
                    Description = "Kelty's got your back during your next chilly night in the backcountry. With the Sine 35° DriDown™ Sleeping Bag, you get the best of both worlds of comfort and light on weight. The Arc Zipper System is there to provide a natural arm motion when opening the bag and for dual venting. Including the water-resistant 800 fill DriDown™ stays drier, lofts better, and dries faster. Part of the Built for Women collection, this Sine sleeping bag has added down for added warmth. On warmer nights, leave unzipped and use like a blanket. No more bags under the eyes while using the Kelty Built Sine Sleeping Bag on your next adventure!",
                    Link = "https://www.rei.com/product/113901/kelty-sine-20-sleeping-bag"
                };

            var NewGear = new Gear()
                {
                    Id = 999999999,
                    Name = "Crew 11 22-inch Expandable Rollaboard Suiter",
                    Brand = "TravelPro",
                    Type = "Carry-On Luggage",
                    Description = "The civilian version of the original Travelpro® Rollaboard® that airline pilots and flight crews have depended on for decades. Proven and durable carry-on luggage perfect for quick trips with features to keep suits and dresses wrinkle free. Packed with smart features like a dedicated power bank pocket and external USB power port to help pro travelers go the extra 20,000 miles.",
                    Link = "https://www.travelpro.com/crew-11-22-expandable-rollaboard-suiter-4071622"
                };

            var Person1 = new Person()
                {
                    Id = 999999998,
                    Name = "Sum Yung Pozer",
                    Email = "sumyungpozer@pozers.com",
                    Bio = "Really great hiker",
                    Friends = null,
                    Gear = null,
                    Places = null,
                    Trails = null,
                    Trips = null
                };

            var NewPerson = new Person()
                {
                    Id = 999999999,
                    Name = "Travis Lerr",
                    Email = "t.lerr@gofar-ish.com",
                    Bio = "Loves travel with money to burn. Tells people he's backpacking.",
                    Friends = null,
                    Gear = null,
                    Places = null,
                    Trails = null,
                    Trips = null
                };

            var Trail1 = new Trail()
                {
                    Id = 999999998,
                    Name = "Sand Point Marsh Trail",
                    Place = Place,
                    Description = "Length: 0.5 mile loop. Look for wildlife along this boardwalk trail leading through a beautiful wetland. Entrance located across from Sand Point Beach. The trail is disability accessible.",
                    Link = "https://www.nps.gov/piro/planyourvisit/dayhikes.htm"
                };

            var NewTrail = new Trail()
                {
                    Id = 999999999,
                    Name = "A Brand new Trail",
                    Place = NewPlace,
                    Description = "A brand new one we know precious little about.",
                    Link = "https://www.google.com"
                };

            var Trip1 = new Trip()
                {
                    Id = 999999991,
                    Name = "Tibilisi Trip",
                    Description = "Went ot see the old cathedral"
                };
            
            Trip1.AssociatePerson(Person1);
            Trip1.AssociateGear(Gear1);
            Trip1.AssociatePlace(Place1);
            Trip1.AssociateTrail(Trail1);

            //Tests...
            var newId = 999999999;
            Trip1.ChangeId(newId);
            var expectedId = newId;
            var actualId = Trip1.Id;
            Assert.Equal(expectedId, actualId);
            
            var newName = "Tbilisi Trip";
            Trip1.ChangeName(newName);
            var expectedName = newName;
            var actualName = Trip1.Name;
            Assert.Equal(expectedName, actualName);
            
            var newPlace = NewPlace;
            var expectedPlace = newPlace;
            Trip1.AssociatePlace(newPlace);
            Assert.True(Trip1.Places.Contains(newPlace));
            Trip1.DisassociatePlace(Place1);
            Assert.False(Trip1.Places.Contains(Place1));
            var actualPlace = Trip1.Places[0];
            Assert.Same(expectedPlace, actualPlace);
            
            var newGear = NewGear;
            var expectedGear = newGear;
            Trip1.AssociateGear(newGear);
            Assert.True(Trip1.GearList.Contains(newGear));
            Trip1.DisassociateGear(Gear1);
            Assert.False(Trip1.GearList.Contains(Gear1));
            var actualGear = Trip1.GearList[0];
            Assert.Same(expectedGear, actualGear);
            
            var newPerson = NewPerson;
            var expectedPerson = newPerson;
            Trip1.AssociatePerson(newPerson);
            Assert.True(Trip1.Companions.Contains(newPerson));
            Trip1.DisassociatePerson(Person1);
            Assert.False(Trip1.Companions.Contains(Person1));
            var actualPerson = Trip1.Companions[0];
            Assert.Same(expectedPerson, actualPerson);
            
            var newTrail = NewTrail;
            var expectedTrail = newTrail;
            Trip1.AssociateTrail(newTrail);
            Assert.True(Trip1.Trails.Contains(newTrail));
            Trip1.DisassociateTrail(Trail1);
            Assert.False(Trip1.Trails.Contains(Trail1));
            var actualTrail = Trip1.Trails[0];
            Assert.Same(expectedTrail, actualTrail);

            var newDescription = "Went to see the old cathedral";
            Trip1.ChangeDescription(newDescription);
            var expectedDescription = newDescription;
            var actualDescription = Trip1.Description;
            Assert.Equal(expectedDescription, actualDescription);
        }
    }
}