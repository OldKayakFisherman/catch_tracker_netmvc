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

        
        /*
        var query = from ct in this._ctx.CatchDetails
            group ct by ct.Species into grp
            select new 
                {
                    key = grp.Key,
                    cnt = grp.Count()
                }
        */

        return this._ctx.CatchDetails.GroupBy(cd => cd.Species)
            .OrderBy(group => group.Key)
            .Select(group => Tuple.Create(group.Key, group.Count()))
            .Take(3)
            .ToList();

        /*
        return _ctx.CatchDetails
            .Distinct()
            .GroupBy(x => x.Species)
            .Select(g => new Tuple<string, int>(
                g.Key,
                g.Count()
            ))
            .OrderByDescending(g => g.Item2)
            .Take(3)
            .ToList();
        */
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