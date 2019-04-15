using System;
using Xunit;
using AMIS3610.GroupProject.Api.Models;

namespace AMIS3610.GroupProject.Api.Tests
{
    public class TrailTest
    {
        public TrailTest()
        {
        }

        [Fact]
        public void ChangeAttributes()
        {
            var Place = new Place()
                {
                    Id = 999999996,
                    Name = "Glacier National Park",
                    Location = "The border of Canada and the United States",
                    Type = "National Park",
                    Description = "Named for the remnants of glaciers from the ice age, Glacier National Park is located on the border of Canada and the United States and is often called the \"Crown of the Continent\" since it sits at the headwaters of the streams that flow into the Pacific Ocean, the Gulf of Mexico and Hudson Bay. A favorite among hikers, the park features a variety of trails for all skill levels, ranging from the easy Trail of the Cedars to the challenging Grinnell Glacier. What's more, the park boasts more than 700 lakes, numerous waterfalls and two mountain ranges, spread across more than 1 million acres that shelter an array of wildlife. Aside from its breathtaking geological features, it's also home to a fair amount of history. The Going-to-the-Sun Road – a scenic, 52-mile drive through the park – is a National Historic Landmark and an engineering marvel that offers spectacular views, as well as access to popular hiking trails. Plus, many of the park's lodges, chalets and hotels were constructed by the Great Northern Railway in the early 20th century and are on the National Register of Historic Places. Care to visit a UNESCO World Heritage site? You'll find that here, too: the Waterton-Glacier International Peace Park.",
                    Link = "https://www.nps.gov/glac/index.htm"
                };

            var NewPlace = new Place()
                {
                    Id = 999999997,
                    Name = "Pictured Rocks National Lakeshore",
                    Location = "Lake Superior Shore",
                    Type = "National Park",
                    Description = "Sandstone cliffs, beaches, sand dunes, waterfalls, inland lakes, deep forest, and wild shoreline beckon you to visit Pictured Rocks National Lakeshore. The power of Lake Superior shapes the park's coastal features and affects every ecosystem, creating a unique landscape to explore. Hiking, camping, sightseeing, and four-season outdoor opportunities abound.",
                    Link = "https://www.nps.gov/piro/index.htm"
                };

            var Trail = new Trail()
                {
                    Id = 999999998,
                    Name = "Sand Point Marsh Trail",
                    Place = Place,
                    Description = "Length: 0.5 mile loop. Look for wildlife along this boardwalk trail leading through a beautiful wetland. Entrance located across from Sand Point Beach. The trail is disability accessible.",
                    Link = "https://www.nps.gov/piro/planyourvisit/dayhikes.htm"
                };

            var newId = 999999999;
            Trail.ChangeId(newId);
            var expectedId = newId;
            var actualId = Trail.Id;
            Assert.Equal(expectedId, actualId);
            
            var newName = "Envoy Hostel Tblisi";
            Trail.ChangeName(newName);
            var expectedName = newName;
            var actualName = Trail.Name;
            Assert.Equal(expectedName, actualName);
            
            var newPlace = NewPlace;
            Trail.ChangePlace(NewPlace);
            var expectedPlace = newPlace;
            var actualPlace = Trail.Place;
            Assert.Equal(expectedPlace, actualPlace);

            var newDescription = "Enjoy breathtaking views of Tbilisi from our huge roof top terrace. Step outside and you are smack in the middle of the Old Town area. This is the trail to be! Perfectly located, Envoy delivers more than just a bed to sleep in. Sharing your passion for travel, everything has been designed with the modern traveller in mind. Relax in our clean and modern rooms. Meet like-minded travellers in our common room decorated with quirky and fun detail. Enjoy our facilities and services including our new kitchen, Discount on tours, Free WiFi, tasty Free breakfast, Free luggage storage and much more.";
            Trail.ChangeDescription(newDescription);
            var expectedDescription = newDescription;
            var actualDescription = Trail.Description;
            Assert.Equal(expectedDescription, actualDescription);
            
            var newLink = "https://www.envoyhostel.com/tbilisi/tbilisi-rooms-rates/";
            Trail.ChangeLink(newLink);
            var expectedLink = newLink;
            var actualLink = Trail.Link;
            Assert.Equal(expectedLink, actualLink);
        }
    }
}
