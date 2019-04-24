using System;
using Xunit;
using AMIS3610.GroupProject.Api.Models;

namespace AMIS3610.GroupProject.Api.Tests
{
    public class ItemTest
    {
        public ItemTest()
        {
        }

        [Fact]
        public void ChangeAttributes()
        {
            var ItemToTest = new Item()
                {
                    Id = 999999900,
                    Name = "Item to Test",
                    Brand = "Test Brand",
                    Type = "Test Type",
                    Description = "Test Description.",
                    Link = "http://www.google.com/"
                };
            Assert.NotNull(ItemToTest);

            var newId = 999999901;
            ItemToTest.ChangeId(newId);
            var expectedId = newId;
            var actualId = ItemToTest.Id;
            Assert.Equal(expectedId, actualId);
            
            var newName = "New Test Name";
            ItemToTest.ChangeName(newName);
            var expectedName = newName;
            var actualName = ItemToTest.Name;
            Assert.Equal(expectedName, actualName);
            
            var newBrand = "New Test Brand";
            ItemToTest.ChangeBrand(newBrand);
            var expectedBrand = newBrand;
            var actualBrand = ItemToTest.Brand;
            Assert.Equal(expectedBrand, actualBrand);
            
            var newType = "New Test Type";
            ItemToTest.ChangeType(newType);
            var expectedType = newType;
            var actualType = ItemToTest.Type;
            Assert.Equal(expectedType, actualType);

            var newDescription = "New Test Description";
            ItemToTest.ChangeDescription(newDescription);
            var expectedDescription = newDescription;
            var actualDescription = ItemToTest.Description;
            Assert.Equal(expectedDescription, actualDescription);
            
            var newLink = "https://justflipacoin.com/";
            ItemToTest.ChangeLink(newLink);
            var expectedLink = newLink;
            var actualLink = ItemToTest.Link;
            Assert.Equal(expectedLink, actualLink);
        }
    }
}
