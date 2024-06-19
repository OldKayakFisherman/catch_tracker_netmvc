using CatchTrackerNetMVC.Web.Data.Entities;
using CatchTrackerNetMVC.Web.Data.Repositories;

namespace CatchTrackerNetMVC.Web.Tests.Data.Repositories;

[TestFixture]
public class LookupRepositoryTests
{
    [TestCase]
    public void TestGetUniqueTechniques()
    {
        using (var factory = new TestApplicationDbContextFactory())
        {
            using (var ctx = factory.CreateContext())
            {
                //Instantiate our repository
                LookupRepository lookupRepo = new LookupRepository(ctx);
                CatchRepository catchRepository = new CatchRepository(ctx);

                //Create some test records
                IList<CatchDetail> catchRecords = TestDataHelper.CreateTestCatchDetails(100);

                catchRepository.BulkAdd(catchRecords);

                IList<string> uniqueRecords = lookupRepo.GetUniqueTechniques();


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
                LookupRepository lookupRepo = new LookupRepository(ctx);
                CatchRepository catchRepository = new CatchRepository(ctx);

                //Create some test records
                IList<CatchDetail> catchRecords = TestDataHelper.CreateTestCatchDetails(100);

                catchRepository.BulkAdd(catchRecords);

                IList<string> uniqueRecords = lookupRepo.GetUniqueTerminalTackle();


                Assert.IsNotNull(uniqueRecords);
                Assert.Greater(uniqueRecords.Count, 0);
                Assert.LessOrEqual(uniqueRecords.Count, 3);

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
                LookupRepository lookupRepo = new LookupRepository(ctx);
                CatchRepository catchRepository = new CatchRepository(ctx);

                //Create some test records
                IList<CatchDetail> catchRecords = TestDataHelper.CreateTestCatchDetails(100);

                catchRepository.BulkAdd(catchRecords);

                IList<string> uniqueRecords = lookupRepo.GetUniqueSpecies();


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
                LookupRepository lookupRepo = new LookupRepository(ctx);
                CatchRepository catchRepository = new CatchRepository(ctx);

                //Create some test records
                IList<CatchDetail> catchRecords = TestDataHelper.CreateTestCatchDetails(100);

                catchRepository.BulkAdd(catchRecords);

                IList<string> uniqueRecords = lookupRepo.GetUniqueSkyConditions();


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
                LookupRepository lookupRepo = new LookupRepository(ctx);
                CatchRepository catchRepository = new CatchRepository(ctx);

                //Create some test records
                IList<CatchDetail> catchRecords = TestDataHelper.CreateTestCatchDetails(100);

                catchRepository.BulkAdd(catchRecords);

                IList<string> uniqueRecords = lookupRepo.GetUniqueBaits();


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
                LookupRepository lookupRepo = new LookupRepository(ctx);
                CatchRepository catchRepository = new CatchRepository(ctx);

                //Create some test records
                IList<CatchDetail> catchRecords = TestDataHelper.CreateTestCatchDetails(100);

                catchRepository.BulkAdd(catchRecords);

                IList<string> uniqueRecords = lookupRepo.GetUniqueRods();


                Assert.IsNotNull(uniqueRecords);
                Assert.Greater(uniqueRecords.Count, 0);
                Assert.LessOrEqual(uniqueRecords.Count, 2);

            }
        }
    }
}