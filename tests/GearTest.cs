using System;
using Xunit;
using AMIS3610.GroupProject.Api.Models;

namespace AMIS3610.GroupProject.Api.Tests
{
    public class GearTest
    {
        public GearTest()
        {
        }

        [Fact]
        public void ChangeAttributes()
        {
            var Gear = new Gear()
                {
                    Id = 999999900,
                    Name = "Test Gear",
                    Brand = "Test Brand",
                    Type = "Test Type",
                    Description = "Test Description.",
                    Link = "http://www.google.com/"
                };

            var newId = 999999901;
            Gear.ChangeId(newId);
            var expectedId = newId;
            var actualId = Gear.Id;
            Assert.Equal(expectedId, actualId);
            
            var newName = "New Test Name";
            Gear.ChangeName(newName);
            var expectedName = newName;
            var actualName = Gear.Name;
            Assert.Equal(expectedName, actualName);
            
            var newBrand = "New Test Brand";
            Gear.ChangeBrand(newBrand);
            var expectedBrand = newBrand;
            var actualBrand = Gear.Brand;
            Assert.Equal(expectedBrand, actualBrand);
            
            var newType = "New Test Type";
            Gear.ChangeType(newType);
            var expectedType = newType;
            var actualType = Gear.Type;
            Assert.Equal(expectedType, actualType);

            var newDescription = "New Test Description";
            Gear.ChangeDescription(newDescription);
            var expectedDescription = newDescription;
            var actualDescription = Gear.Description;
            Assert.Equal(expectedDescription, actualDescription);
            
            var newLink = "https://justflipacoin.com/";
            Gear.ChangeLink(newLink);
            var expectedLink = newLink;
            var actualLink = Gear.Link;
            Assert.Equal(expectedLink, actualLink);
        }
    }
}
