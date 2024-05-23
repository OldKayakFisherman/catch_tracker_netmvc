

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

    public void BulkInsert(IList<CatchDetail> catches)
    {
        _ctx.BulkInsert<CatchDetail>(catches);
    }
    
    public IList<string> GetUniqueTechniques()
    {
        return _ctx.CatchDetails
            .Where(c => c.Technique != null)
            .Select(t => t.Technique)
            .Distinct()!
            .ToList<string>();
    }
}