namespace CatchTrackerNetMVC.Web.Data.Repositories;

public class StatsRepository
{
    private readonly ApplicationDbContext _ctx;

    public StatsRepository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
    }
    
    
}