using System.Runtime.InteropServices.JavaScript;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace CatchTrackerNetMVC.Web.Data.Repositories;

public class StatsRepository
{
    private readonly ApplicationDbContext _ctx;

    public StatsRepository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
    }


    public IList<Tuple<string, int>> YtdCatchStatsOverall()
    {
        var startDate = new DateTime(DateTime.Now.Year, 1, 1);
        var endDate = new DateTime(DateTime.Now.Year, 1, 1, 23, 59, 59);
        
        return this._ctx.CatchDetails.GroupBy(cd => cd.Species)
            .OrderBy(group => group.Key)
            .Select(group => Tuple.Create(group.Key, group.Count()))
            .ToList();
    }
    
    //ytd_catch_stats_by_species
    public Tuple<string, int>? YtdCatchStatsBySpecies()
    {
        return null;
    }
    
    //ytd_top_techniques
    public Tuple<string, int>? YtdCatchStatsTopTechniques()
    {
        return null;
    }
    
    //prior_yr_top_techniques
    public Tuple<string, int>? PriorYrCatchStatsTopTechniques()
    {
        return null;
    }
    
    //ytd_top_baits
    public Tuple<string, int>? YtdCatchStatsTopBaits()
    {
        return null;
    }
    
    //prior_yr_top_baits
    public Tuple<string, int>? PriorYrCatchStatsTopBaits()
    {
        return null;
    }
    
    
   
}