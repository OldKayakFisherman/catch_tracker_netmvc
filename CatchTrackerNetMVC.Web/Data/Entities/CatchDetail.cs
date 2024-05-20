using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace CatchTrackerNetMVC.Web.Data.Entities;

[Table("catch_details")]
public class CatchDetail
{

    [Key][Column("id")] 
    public int? Id { get; set; }

    [Column("latitude")] 
    public double Latitude { get; set; }

    [Column("longitude")] 
    public double Longitude { get; set; }
    
    [Column("catch_date")] 
    public DateTime CatchDate{ get; set; }
    
    [Column("species")] 
    [MaxLength(50)]
    public string Species{ get; set; }

    [Column("weight")] 
    public double Weight { get; set; }
    
    [Column("water_temperature")] 
    public double WaterTemperature { get; set; }

    [Column("water_depth")] 
    public double WaterDepth { get; set; }

    [Column("sky_conditions")] 
    [MaxLength(100)]
    public string? SkyConditions{ get; set; }
    
    [Column("air_temperature")] 
    public double AirTemperature { get; set; }

    [Column("terminal_tackle")] 
    [MaxLength(1000)]
    public string? TerminalTackle{ get; set; }
    
    [Column("technique")] 
    [MaxLength(1000)]
    public string? Technique { get; set; }
    
    [Column("bait")] 
    [MaxLength(1000)]
    public string? Bait { get; set; }

    [Column("rod")] 
    [MaxLength(1000)]
    public string? Rod { get; set; }

    public ICollection<Media>? Media { get; set; } = new List<Media>();

    public CatchDetail(double latitude, double longitude, DateTime catchDate, string species)
    {
        Latitude = latitude;
        Longitude = longitude;
        CatchDate = catchDate;
        Species = species;
    }
    
   
}