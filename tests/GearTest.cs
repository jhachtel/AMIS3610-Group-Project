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
                    Id = 999999998,
                    Name = "SINE 34",
                    Brand = "Kelti",
                    Type = "Blanket",
                    Description = "Kelties got your back during your next chilly night in the backcountry. With the Sine 35° DriDown™ Sleeping Bag, you get the best of both worlds of comfort and light on weight. The Arc Zipper System is there to provide a natural arm motion when opening the bag and for dual venting. Including the water-resistant 800 fill DriDown™ stays drier, lofts better, and dries faster. Part of the Built for Women collection, this Sine sleeping bag has added down for added warmth. On warmer nights, leave unzipped and use like a blanket. No more bags under the eyes while using the Kelty Built Sine Sleeping Bag on your next adventure!",
                    Link = "https://www.re1.com/product/113901/kelty-sine-20-sleeping-bag"
                };

            var newId = 999999999;
            Gear.ChangeId(newId);
            var expectedId = newId;
            var actualId = Gear.Id;
            Assert.Equal(expectedId, actualId);
            
            var newName = "SINE 35";
            Gear.ChangeName(newName);
            var expectedName = newName;
            var actualName = Gear.Name;
            Assert.Equal(expectedName, actualName);
            
            var newBrand = "Kelty";
            Gear.ChangeBrand(newBrand);
            var expectedBrand = newBrand;
            var actualBrand = Gear.Brand;
            Assert.Equal(expectedBrand, actualBrand);
            
            var newType = "Sleeping Bag";
            Gear.ChangeType(newType);
            var expectedType = newType;
            var actualType = Gear.Type;
            Assert.Equal(expectedType, actualType);

            var newDescription = "Kelty's got your back during your next chilly night in the backcountry. With the Sine 35° DriDown™ Sleeping Bag, you get the best of both worlds of comfort and light on weight. The Arc Zipper System is there to provide a natural arm motion when opening the bag and for dual venting. Including the water-resistant 800 fill DriDown™ stays drier, lofts better, and dries faster. Part of the Built for Women collection, this Sine sleeping bag has added down for added warmth. On warmer nights, leave unzipped and use like a blanket. No more bags under the eyes while using the Kelty Built Sine Sleeping Bag on your next adventure!";
            Gear.ChangeDescription(newDescription);
            var expectedDescription = newDescription;
            var actualDescription = Gear.Description;
            Assert.Equal(expectedDescription, actualDescription);
            
            var newLink = "https://www.rei.com/product/113901/kelty-sine-20-sleeping-bag";
            Gear.ChangeLink(newLink);
            var expectedLink = newLink;
            var actualLink = Gear.Link;
            Assert.Equal(expectedLink, actualLink);
        }
    }
}
