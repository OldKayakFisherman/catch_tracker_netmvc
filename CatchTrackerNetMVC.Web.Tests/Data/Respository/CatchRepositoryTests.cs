using CatchTrackerNetMVC.Web.Data.Entities;
using CatchTrackerNetMVC.Web.Data.Repositories;
using CatchTrackerNetMVC.Web.Tests;

namespace CatchTrackerNetMVC.Web.Tests.Data.Respository;

[TestFixture]
public class CatchRepositoryTests
{
    [TestCase]
    public void TestGetUniqueTechniques()
    {
        using (var factory = new TestApplicationDbContextFactory())
        {
            using (var ctx = factory.CreateContext())
            {
                //Instantiate our repository
                CatchRepository repo = new CatchRepository(ctx);
                
                //Create some test records
                IList<CatchDetail> catchRecords = TestDataHelper.CreateTestCatchDetails(100);
                
                repo.BulkInsert(catchRecords);

                IList<string> uniqueTechniques = repo.GetUniqueTechniques();
                
                
                Assert.IsNotNull(uniqueTechniques);
                Assert.Greater(uniqueTechniques.Count, 0);
                Assert.LessOrEqual(uniqueTechniques.Count, 3);
                
                
                
                
                
                
            }
        }
        
    }
}