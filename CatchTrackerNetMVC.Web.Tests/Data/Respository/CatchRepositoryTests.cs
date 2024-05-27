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

                repo.BulkAdd(catchRecords);

                IList<string> uniqueRecords = repo.GetUniqueTechniques();


                Assert.IsNotNull(uniqueRecords);
                Assert.Greater(uniqueRecords.Count, 0);
                Assert.LessOrEqual(uniqueRecords.Count, 3);

            }
        }
    }
    
    [TestCase]
    public void TestGetUniqueTerminalTackle()
    {
        using (var factory = new TestApplicationDbContextFactory())
        {
            using (var ctx = factory.CreateContext())
            {
                //Instantiate our repository
                CatchRepository repo = new CatchRepository(ctx);

                //Create some test records
                IList<CatchDetail> catchRecords = TestDataHelper.CreateTestCatchDetails(100);

                repo.BulkAdd(catchRecords);

                IList<string> uniqueRecords = repo.GetUniqueTerminalTackle();


                Assert.IsNotNull(uniqueRecords);
                Assert.Greater(uniqueRecords.Count, 0);
                Assert.LessOrEqual(uniqueRecords.Count, 2);

            }
        }
    }

    [TestCase]
    public void TestGetUniqueSpecies()
    {
        using (var factory = new TestApplicationDbContextFactory())
        {
            using (var ctx = factory.CreateContext())
            {
                //Instantiate our repository
                CatchRepository repo = new CatchRepository(ctx);

                //Create some test records
                IList<CatchDetail> catchRecords = TestDataHelper.CreateTestCatchDetails(100);

                repo.BulkAdd(catchRecords);

                IList<string> uniqueRecords = repo.GetUniqueSpecies();


                Assert.IsNotNull(uniqueRecords);
                Assert.Greater(uniqueRecords.Count, 0);
                Assert.LessOrEqual(uniqueRecords.Count, 5);

            }
        }
    }

    [TestCase]
    public void TestGetUniqueSkyConditions()
    {
        using (var factory = new TestApplicationDbContextFactory())
        {
            using (var ctx = factory.CreateContext())
            {
                //Instantiate our repository
                CatchRepository repo = new CatchRepository(ctx);

                //Create some test records
                IList<CatchDetail> catchRecords = TestDataHelper.CreateTestCatchDetails(100);

                repo.BulkAdd(catchRecords);

                IList<string> uniqueRecords = repo.GetUniqueSkyConditions();


                Assert.IsNotNull(uniqueRecords);
                Assert.Greater(uniqueRecords.Count, 0);
                Assert.LessOrEqual(uniqueRecords.Count, 4);

            }
        }
    }

    [TestCase]
    public void TestGetUniqueBaits()
    {
        using (var factory = new TestApplicationDbContextFactory())
        {
            using (var ctx = factory.CreateContext())
            {
                //Instantiate our repository
                CatchRepository repo = new CatchRepository(ctx);

                //Create some test records
                IList<CatchDetail> catchRecords = TestDataHelper.CreateTestCatchDetails(100);

                repo.BulkAdd(catchRecords);

                IList<string> uniqueRecords = repo.GetUniqueBaits();


                Assert.IsNotNull(uniqueRecords);
                Assert.Greater(uniqueRecords.Count, 0);
                Assert.LessOrEqual(uniqueRecords.Count, 4);

            }
        }
    }

    [TestCase]
    public void TestGetUniqueRods()
    {
        using (var factory = new TestApplicationDbContextFactory())
        {
            using (var ctx = factory.CreateContext())
            {
                //Instantiate our repository
                CatchRepository repo = new CatchRepository(ctx);

                //Create some test records
                IList<CatchDetail> catchRecords = TestDataHelper.CreateTestCatchDetails(100);

                repo.BulkAdd(catchRecords);

                IList<string> uniqueRecords = repo.GetUniqueRods();


                Assert.IsNotNull(uniqueRecords);
                Assert.Greater(uniqueRecords.Count, 0);
                Assert.LessOrEqual(uniqueRecords.Count, 2);

            }
        }
    }


}