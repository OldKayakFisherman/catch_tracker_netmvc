namespace CatchTrackerNetMVC.Web.Data.Repositories;

public class LookupRepository
{

    private readonly ApplicationDbContext _ctx;
    
    public LookupRepository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
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
            .Where(c => c.TerminalTackle != null)
            .Select(t => t.TerminalTackle)
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