

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
    
    
   
}