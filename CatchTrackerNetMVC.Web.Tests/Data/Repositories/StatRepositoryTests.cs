using CatchTrackerNetMVC.Web.Data.Entities;
using CatchTrackerNetMVC.Web.Data.Repositories;

namespace CatchTrackerNetMVC.Web.Tests.Data.Repositories;

[TestFixture]
public class StatRepositoryTests
{
    [TestCase]
    public void TestYtdCatchStatsOverall()
    {
        using var factory = new TestApplicationDbContextFactory();
        using var ctx = factory.CreateContext();
        //Instantiate our repository
        StatsRepository statsRepo = new StatsRepository(ctx);
        CatchRepository catchRepository = new CatchRepository(ctx);

        //Create some test records
        IList<CatchDetail> catchRecords = TestDataHelper.CreateTestCatchDetails(100);

        catchRepository.BulkAdd(catchRecords);

        IList<Tuple<string, int>> uniqueRecords = statsRepo.YtdCatchStatsOverall();
                
        Assert.IsNotNull(uniqueRecords);
    }
}