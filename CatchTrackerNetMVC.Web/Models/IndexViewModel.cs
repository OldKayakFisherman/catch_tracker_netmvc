namespace CatchTrackerNetMVC.Web.Models;

public class IndexViewModel
{
    public IList<Tuple<string, int>> YtdCatchStatsOverall { get; set; } = new List<Tuple<string, int>>();
    public  IList<Tuple<string, int>> YtdCatchStatsBySpecies { get; set; } = new List<Tuple<string, int>>();
    public  IList<Tuple<string, int>> YtdCatchStatsTopTechniques { get; set; } = new List<Tuple<string, int>>();
    public  IList<Tuple<string, int>> PriorYrCatchStatsTopTechniques { get; set; } = new List<Tuple<string, int>>();
    public  IList<Tuple<string, int>> YtdCatchStatsTopBaits { get; set; } = new List<Tuple<string, int>>();
    public  IList<Tuple<string, int>> PriorYrCatchStatsTopBaits { get; set; } = new List<Tuple<string, int>>();
        
    
}