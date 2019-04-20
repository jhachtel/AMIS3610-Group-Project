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
            var GearToTest = new Gear()
                {
                    Id = 999999900,
                    Name = "Gear to Test",
                    Brand = "Test Brand",
                    Type = "Test Type",
                    Description = "Test Description.",
                    Link = "http://www.google.com/"
                };
            Assert.NotNull(GearToTest);

            var newId = 999999901;
            GearToTest.ChangeId(newId);
            var expectedId = newId;
            var actualId = GearToTest.Id;
            Assert.Equal(expectedId, actualId);
            
            var newName = "New Test Name";
            GearToTest.ChangeName(newName);
            var expectedName = newName;
            var actualName = GearToTest.Name;
            Assert.Equal(expectedName, actualName);
            
            var newBrand = "New Test Brand";
            GearToTest.ChangeBrand(newBrand);
            var expectedBrand = newBrand;
            var actualBrand = GearToTest.Brand;
            Assert.Equal(expectedBrand, actualBrand);
            
            var newType = "New Test Type";
            GearToTest.ChangeType(newType);
            var expectedType = newType;
            var actualType = GearToTest.Type;
            Assert.Equal(expectedType, actualType);

            var newDescription = "New Test Description";
            GearToTest.ChangeDescription(newDescription);
            var expectedDescription = newDescription;
            var actualDescription = GearToTest.Description;
            Assert.Equal(expectedDescription, actualDescription);
            
            var newLink = "https://justflipacoin.com/";
            GearToTest.ChangeLink(newLink);
            var expectedLink = newLink;
            var actualLink = GearToTest.Link;
            Assert.Equal(expectedLink, actualLink);
        }
    }
}
