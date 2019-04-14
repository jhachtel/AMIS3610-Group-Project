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
            var Place = new Place()
                {
                    Id = 999999998,
                    Name = "Envoy Hotel Tiblisi",
                    Location = "Tiblisi, Georgia",
                    Type = "Hotel",
                    Description = "Enjoy breathtaking views of Tibilisi from our huge roof top terrace. Step outside and you are smack in the middle of the Old Town area. This is the place to be! Perfectly located, Envoy delivers more than just a bed to sleep in. Sharing your passion for travel, everything has been designed with the modern traveller in mind. Relax in our clean and modern rooms. Meet like-minded travellers in our common room decorated with quirky and fun detail. Enjoy our facilities and services including our new kitchen, Discount on tours, Free WiFi, tasty Free breakfast, Free luggage storage and much more."
                };

            var newId = 999999999;
            Place.ChangeId(newId);
            var expectedId = newId;
            var actualId = Place.Id;
            Assert.Equal(expectedId, actualId);
            
            var newName = "Envoy Hostel Tblisi";
            Place.ChangeName(newName);
            var expectedName = newName;
            var actualName = Place.Name;
            Assert.Equal(expectedName, actualName);
            
            var newLocation = "Tblisi, Georgia";
            Place.ChangeLocation(newLocation);
            var expectedLocation = newLocation;
            var actualLocation = Place.Location;
            Assert.Equal(expectedLocation, actualLocation);
            
            var newType = "Hostel";
            Place.ChangeType(newType);
            var expectedType = newType;
            var actualType = Place.Type;
            Assert.Equal(expectedType, actualType);

            var newDescription = "Enjoy breathtaking views of Tbilisi from our huge roof top terrace. Step outside and you are smack in the middle of the Old Town area. This is the place to be! Perfectly located, Envoy delivers more than just a bed to sleep in. Sharing your passion for travel, everything has been designed with the modern traveller in mind. Relax in our clean and modern rooms. Meet like-minded travellers in our common room decorated with quirky and fun detail. Enjoy our facilities and services including our new kitchen, Discount on tours, Free WiFi, tasty Free breakfast, Free luggage storage and much more.";
            Place.ChangeDescription(newDescription);
            var expectedDescription = newDescription;
            var actualDescription = Place.Description;
            Assert.Equal(expectedDescription, actualDescription);

        }
    }
}
