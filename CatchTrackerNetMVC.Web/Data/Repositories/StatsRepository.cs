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
        
        return this._ctx.CatchDetails
            .Where(cd => cd.CatchDate <= endDate && cd.CatchDate >= startDate)
            .GroupBy(cd => cd.Species)
            .OrderBy(group => group.Key)
            .Select(group => Tuple.Create(group.Key, group.Count()))
            .ToList();
    }
    
    //ytd_catch_stats_by_species
    public IList<Tuple<string, int>>? YtdCatchStatsBySpecies()
    {
        var startDate = new DateTime(DateTime.Now.Year, 1, 1);
        var endDate = new DateTime(DateTime.Now.Year, 1, 1, 23, 59, 59);
        
        return this._ctx.CatchDetails
            .Where(cd => cd.CatchDate <= endDate && cd.CatchDate >= startDate)
            .GroupBy(cd => cd.Species)
            .OrderBy(group => group.Key)
            .Select(group => Tuple.Create(group.Key, group.Count()))
            .Take(3)
            .ToList();
    }
    
    //ytd_top_techniques
    public IList<Tuple<string, int>>? YtdCatchStatsTopTechniques()
    {
        var startDate = new DateTime(DateTime.Now.Year, 1, 1);
        var endDate = new DateTime(DateTime.Now.Year, 1, 1, 23, 59, 59);
        
        return this._ctx.CatchDetails
            .Where(cd => cd.Technique != null && (cd.CatchDate <= endDate && cd.CatchDate >= startDate))
            .GroupBy(cd => cd.Technique)
            .OrderBy(group => group.Key)
            .Select(group => Tuple.Create(group.Key, group.Count()))
            .Take(3)
            .ToList()!;
    }
    
    //prior_yr_top_techniques
    public IList<Tuple<string, int>>? PriorYrCatchStatsTopTechniques()
    {
        var startDate = new DateTime((DateTime.Now.Year -1), 1, 1);
        var endDate = new DateTime((DateTime.Now.Year -1), 1, 1, 23, 59, 59);
        
        return this._ctx.CatchDetails
            .Where(cd => cd.Technique != null && (cd.CatchDate <= endDate && cd.CatchDate >= startDate))
            .GroupBy(cd => cd.Technique)
            .OrderBy(group => group.Key)
            .Select(group => Tuple.Create(group.Key, group.Count()))
            .Take(3)
            .ToList()!;
    }
    
    //ytd_top_baits
    public IList<Tuple<string, int>>? YtdCatchStatsTopBaits()
    {
        var startDate = new DateTime(DateTime.Now.Year, 1, 1);
        var endDate = new DateTime(DateTime.Now.Year, 1, 1, 23, 59, 59);
        
        return this._ctx.CatchDetails
            .Where(cd => cd.Bait != null && (cd.CatchDate <= endDate && cd.CatchDate >= startDate))
            .GroupBy(cd => cd.Bait)
            .OrderBy(group => group.Key)
            .Select(group => Tuple.Create(group.Key, group.Count()))
            .Take(3)
            .ToList()!;
    }
    
    //prior_yr_top_baits
    public IList<Tuple<string, int>>? PriorYrCatchStatsTopBaits()
    {
        var startDate = new DateTime((DateTime.Now.Year -1), 1, 1);
        var endDate = new DateTime((DateTime.Now.Year -1), 1, 1, 23, 59, 59);
        
        return this._ctx.CatchDetails
            .Where(cd => cd.Technique != null && (cd.CatchDate <= endDate && cd.CatchDate >= startDate))
            .GroupBy(cd => cd.Technique)
            .OrderBy(group => group.Key)
            .Select(group => Tuple.Create(group.Key, group.Count()))
            .Take(3)
            .ToList()!;
    }
    
    
   
}