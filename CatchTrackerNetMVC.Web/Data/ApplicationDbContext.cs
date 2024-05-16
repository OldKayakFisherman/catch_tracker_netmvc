using Microsoft.EntityFrameworkCore;
using CatchTrackerNetMVC.Web.Data.Entities;

namespace CatchTrackerNetMVC.Web.Data;

public class ApplicationDbContext: DbContext
{
   
    public DbSet<CatchDetail> CatchDetails { get; set; }
    public DbSet<Media> Media { get; set; }
    public DbSet<SearchIndex> SearchIndexes { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {}
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Media>()
            .HasOne<CatchDetail>(m => m.CatchDetail)
            .WithMany(c => c.Media)
            .HasForeignKey(m => m.CatchDetailId);

        builder.Entity<SearchIndex>()
            .HasOne<CatchDetail>(s => s.CatchDetail);
    }
}