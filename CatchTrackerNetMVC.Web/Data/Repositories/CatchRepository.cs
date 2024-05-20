

using System.Collections.ObjectModel;

namespace CatchTrackerNetMVC.Web.Data.Repositories;

public class CatchRepository
{
    private readonly ApplicationDbContext _ctx;
    
    public CatchRepository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
    }
    
    public IList<string?> GetUniqueTechniques()
    {
        return _ctx.CatchDetails
            .Where(c => c.Technique != null)
            .Select(t => t.Technique)
            .Distinct()
            .ToList<string?>();
    }
}