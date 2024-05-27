

using System.Collections.ObjectModel;
using CatchTrackerNetMVC.Web.Data.Entities;
using EFCore.BulkExtensions;

namespace CatchTrackerNetMVC.Web.Data.Repositories;

public class CatchRepository
{
    private readonly ApplicationDbContext _ctx;
    
    public CatchRepository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
    }

    public void BulkAdd(IList<CatchDetail> catches)
    {
        _ctx.BulkInsert<CatchDetail>(catches);
        _ctx.SaveChanges();
    }

    public void Add(CatchDetail catchDetail)
    {
        _ctx.Add<CatchDetail>(catchDetail);
        _ctx.SaveChanges();
    }
    
    
    public IList<string> GetUniqueTechniques()
    {
        return _ctx.CatchDetails
            .Where(c => c.Technique != null)
            .Select(t => t.Technique)
            .Distinct()!
            .ToList<string>();
    }
    
    public IList<string> GetUniqueTerminalTackle()
    {
        return _ctx.CatchDetails
            .Where(c => c.Technique != null)
            .Select(t => t.Technique)
            .Distinct()!
            .ToList<string>();
    }
    
    public IList<string> GetUniqueSpecies()
    {
        return _ctx.CatchDetails
            .Where(c => true)
            .Select(t => t.Species)
            .Distinct()
            .ToList<string>();
    }
    
    public IList<string> GetUniqueSkyConditions()
    {
        return _ctx.CatchDetails
            .Where(c => c.SkyConditions != null)
            .Select(t => t.SkyConditions)
            .Distinct()!
            .ToList<string>();
    }
    
    public IList<string> GetUniqueBaits()
    {
        return _ctx.CatchDetails
            .Where(c => c.Bait != null)
            .Select(t => t.Bait)
            .Distinct()!
            .ToList<string>();
    }
    
    public IList<string> GetUniqueRods()
    {
        return _ctx.CatchDetails
            .Where(c => c.Rod != null)
            .Select(t => t.Rod)
            .Distinct()!
            .ToList<string>();
    }
    
}