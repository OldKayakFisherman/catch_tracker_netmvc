using Bogus;

using CatchTrackerNetMVC.Web.Data.Entities;

namespace CatchTrackerNetMVC.Web.Tests;

public static class TestDataHelper
{
    public static IList<CatchDetail> CreateTestCatchDetails(int number = 1)
    {
        var faker = new Faker("en");
        
        IList<CatchDetail> catchDetails = new List<CatchDetail>();

        var techniqueList = new[] { "Aggressive Jerkbait Retrieve", "Texas Rig", "Slow Rolling" };
        var speciesList = new[] { "Bass", "Perch", "Crappie", "Catfish", "Snakehead" };
        var skyConditionsList = new[] { "Cloudy", "Sunny", "Partly Cloudy", "Light Rain" };
        var baitList = new[]
        {
            "Rapala Purple and Gold Rip Shad", 
            "Missle White Shockwave Paddletail", 
            "Zoom Speedcraw", 
            "Zoom Speedworm"
        };

        var rodsList = new[]
        {
            "Rod Setup 1",
            "Rod Setup 2"
        };

        for (var i = 1; i < number; i++)
        {
            var latitude = faker.Address.Latitude();
            var longitude = faker.Address.Longitude();
            var catchDate = faker.Date.Past();
            var species = faker.Random.ArrayElements(baitList, 1).First();
            
            var catchDetail = new CatchDetail
            (
                latitude,
                longitude,
                catchDate,
                species
            )
            {
                Bait = faker.Random.ArrayElements(baitList, 1).First(),
                AirTemperature = faker.Random.Double(),
                Rod = faker.Random.ArrayElements(rodsList, 1).First(),
                Weight = faker.Random.Double(),
                SkyConditions = faker.Random.ArrayElements(skyConditionsList, 1).First(),
                Technique = faker.Random.ArrayElements(techniqueList, 1).First(),
                WaterDepth = faker.Random.Double(),
                
            };
        }
        
        
        
        
        
    }
}